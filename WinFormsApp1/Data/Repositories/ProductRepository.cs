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
    public class ProductRepository : DBHelper, IProductRepository
    {
        public DataTable GetAllProducts()
        {
            try
            {
                string query = @"
                    SELECT * FROM Products
                ";
                return ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error loading products: " + ex.Message);
                return null;
            }
        }

    }
}
