using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Data.Helper
{
    public abstract class DBHelper
    {
        //Connection String
        protected readonly string connStr = @"Data Source=DESKTOP-RFBLLP8;Initial Catalog=EShift_DB;Integrated Security=True";
        
        protected DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                using SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }catch (Exception ex) { throw new Exception(ex.Message, ex); }
        }

        protected int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connStr);
                using SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message, ex); }
        }
    }
}
