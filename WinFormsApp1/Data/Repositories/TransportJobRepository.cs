using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data.Helper;
using WinFormsApp1.Data.Models;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Data.Repositories
{
    public class TransportJobRepository : DBHelper, ITransportJobRepository
    {
        public DataTable GetTransportJobStatusByCustomerID(int customerID, string statusFilter)
        {
            try
            {
                string query = @"
                    SELECT JobID, StartLocation, Destination, JobStatus, RequestDate, ScheduledDate
                    FROM TransportJobs
                    WHERE CustomerID = @CustomerID
                ";

                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@CustomerID", customerID)
                };

                if (statusFilter != "All")
                {
                    query += " AND JobStatus = @JobStatus";
                    parameters.Add(new SqlParameter("@JobStatus", statusFilter));
                }
                return ExecuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error retrieving job status: " + ex.Message);
                return null;
            }
        }

        public DataTable GetPendingJobs()
        {
            try
            {
                string query = @"
                    SELECT 
                        tj.JobID,
                        c.UserID,
                        c.FullName AS CustomerName,
                        tj.StartLocation,
                        tj.Destination,
                        tj.RequestDate,
                        tj.ScheduledDate,
                        tj.JobStatus
                    FROM TransportJobs tj
                    JOIN Customers c ON tj.CustomerID = c.CustomerID
                    WHERE tj.JobStatus = 'Pending'
                ";
                return ExecuteQuery(query, null);
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error retrieving pending jobs: " + ex.Message);
                return null;
            }
        }

        public DataTable GetAcceptedJobsByCustomerID(int customerID)
        {
            try
            {
                string query = @"
                    SELECT JobID FROM TransportJobs WHERE JobStatus = 'Accepted' AND CustomerID = @CustomerID
                ";
                return ExecuteQuery(query, new SqlParameter("@CustomerID", customerID));
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error retrieving accepted jobs: " + ex.Message);
                return null;
            }
        }

        public bool CreateJob(TransportJobModel transportJob)
        {
            try
            {
                string query = @"
                    INSERT INTO TransportJobs 
                    (CustomerID, StartLocation, Destination, JobStatus, RequestDate, ScheduledDate) 
                    VALUES 
                    (@CustomerID, @StartLocation, @Destination, @JobStatus, @RequestDate, @ScheduledDate);
                ";

                ExecuteNonQuery(query,
                    new SqlParameter("@CustomerID", transportJob.CustomerID),
                    new SqlParameter("@StartLocation", transportJob.StartLocation),
                    new SqlParameter("@Destination", transportJob.Destination),
                    new SqlParameter("@JobStatus", transportJob.JobStatus),
                    new SqlParameter("@RequestDate", transportJob.RequestDate),
                    new SqlParameter("@ScheduledDate", transportJob.ScheduledDate)
                );
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error creating job: " + ex.Message);
                return false;
            }
        }
    }
}
