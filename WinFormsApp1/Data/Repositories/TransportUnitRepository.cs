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
    public class TransportUnitRepository : DBHelper, ITransportUnitRepository
    {
        public DataTable GetAllTransportUnits()
        {
            try
            {
                string query = @"
                    SELECT * FROM TransportUnits
                ";
                return ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error loading transport units: " + ex.Message);
                return null;
            }
        }

    }
}
