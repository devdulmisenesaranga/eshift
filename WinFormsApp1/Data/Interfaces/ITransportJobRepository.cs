using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data.Helper;
using WinFormsApp1.Data.Models;

namespace WinFormsApp1.Data.Repositories
{
    public interface ITransportJobRepository
    {
        DataTable GetTransportJobStatusByCustomerID(int customerID, string statusFilter);
        DataTable GetPendingJobs();
        DataTable GetAcceptedJobsByCustomerID(int customerID);
        bool CreateJob(TransportJobModel transportJob);
    }
}
