using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data.Helper;
using WinFormsApp1.Data.Models;
using WinFormsApp1.Utils;

namespace WinFormsApp1.Data.Repositories
{
    public class UserRepository : DBHelper, IUserRepository
    {
        public DataTable GetAdmins()
        {
            try
            {
                string query = @"
                    SELECT UserID, Username, IsActive FROM Users WHERE Role = 'Admin'
                ";
                return ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                // Log the exception (you can replace this with your logging mechanism)
                MessageBoxHelper.ShowError($"Error in GetAdmins: {ex.Message}");
                return null;  // or return new DataTable() if you prefer
            }
        }

        public bool CreateAdmin(UserModel user)
        {
            try
            {
                string query = @"
                    INSERT INTO Users (Username, PasswordHash, Role, IsActive) VALUES (@User, @Hash, 'Admin', 1)
                ";

                ExecuteNonQuery(query,
                    new SqlParameter("@User", user.Username),
                    new SqlParameter("@Hash", user.PasswordHash)
                );
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError($"Error in CreateAdmin: {ex.Message}");
                return false;
            }
        }

        public bool UpdateAdmin(UserModel user, bool isPwNull = false)
        {
            try
            {
                string query;
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@ID", user.UserID),
                    new SqlParameter("@Active", user.IsActive),
                };
                if (!isPwNull)
                {
                    query = "UPDATE Users SET PasswordHash = @Hash, IsActive = @Active WHERE UserID = @ID";
                    parameters.Add(new SqlParameter("@Hash", user.PasswordHash));
                }
                else
                {
                    query = "UPDATE Users SET IsActive = @Active WHERE UserID = @ID";
                }
                ExecuteNonQuery(query, parameters.ToArray());
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError($"Error in UpdateAdmin: {ex.Message}");
                return false;
            }
        }

        public bool DeleteAdmin(int id)
        {
            try
            {
                string query = @"
                    DELETE FROM Users WHERE UserID = @UserID AND Role = 'Admin'
                ";

                ExecuteNonQuery(query,
                    new SqlParameter("@UserID", id)
                );
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError($"Error in DeleteAdmin: {ex.Message}");
                return false;
            }
        }

    }
}
