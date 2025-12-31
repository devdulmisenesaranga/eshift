using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data.Helper;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Data.Repositories
{
    public class JobLoadRepository : DBHelper, IJobLoadRepository
    {
        public DataTable GetLoadsByJobID(int jobID)
        {
            try
            {
                string query = @"
            SELECT LoadID, ProductID, Weight, Volume, TransportUnitID
            FROM Loads WHERE JobID = @JobID
        ";
                return ExecuteQuery(query, new SqlParameter("@JobID", jobID));
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Failed to load loads: " + ex.Message);
                return null;
            }
        }

        public DataTable GetLoadDetailsByJobID(int jobID)
        {
            try
            {
                string query = @"
            SELECT L.LoadID, P.ProductName, L.Weight, L.Volume 
            FROM Loads L
            LEFT JOIN Products P ON L.ProductID = P.ProductID
            WHERE L.JobID = @JobID
        ";
                return ExecuteQuery(query, new SqlParameter("@JobID", jobID));
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Failed to load load details: " + ex.Message);
                return null;
            }
        }

        public DataTable GetJobLoadDetailsByJobID(int jobID)
        {
            try
            {
                string query = @"
            SELECT
                L.LoadID,
                P.ProductName,
                L.Weight,
                L.Volume,
                T.LorryPlate
            FROM Loads L
            LEFT JOIN Products P ON L.ProductID = P.ProductID
            LEFT JOIN TransportUnits T ON L.TransportUnitID = T.TransportUnitID
            LEFT JOIN TransportJobs J ON L.JobID = J.JobID
            WHERE J.JobID = @JobID
        ";
                return ExecuteQuery(query, new SqlParameter("@JobID", jobID));
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Failed to load full job details: " + ex.Message);
                return null;
            }
        }
    }
}
