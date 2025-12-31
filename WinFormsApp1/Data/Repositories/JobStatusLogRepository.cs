using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data.Helper;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Data.Repositories
{
    public class JobStatusLogRepository : DBHelper, IJobStatusLogRepository
    {
        public DataTable GetJobStatusLogDetails()
        {
            try
            {
                string query = @"
                    EXEC GetJobStatusLogDetails
                ";
                return ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error retrieving job status logs: " + ex.Message);
                return null;
            }
        }
    }
}
