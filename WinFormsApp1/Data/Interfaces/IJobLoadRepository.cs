using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data.Helper;

namespace WinFormsApp1.Data.Repositories
{
    public interface IJobLoadRepository
    {
        DataTable GetLoadsByJobID(int jobID);
        DataTable GetLoadDetailsByJobID(int jobID);
        DataTable GetJobLoadDetailsByJobID(int jobID);
    }
}
