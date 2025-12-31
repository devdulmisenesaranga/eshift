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
    public class CustomerRepository : DBHelper, ICustomerRepository
    {
        public DataTable GetAllCustomers()
        {
            try
            {
                string query = @"
                SELECT 
                    c.CustomerID,
                    u.Username,
                    c.FullName,
                    c.Email,
                    c.Phone,
                    c.Address
                FROM Customers c
                INNER JOIN Users u ON c.UserID = u.UserID
                ";
                return ExecuteQuery(query, null);
            }catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error get all customers");
                return null;
            }
        }
    }
}
