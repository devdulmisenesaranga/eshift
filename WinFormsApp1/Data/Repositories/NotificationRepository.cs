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
    public class NotificationRepository : DBHelper, INotificationRepository
    {
        public DataTable GetAllNotificationsByUserID(int userID)
        {
            try
            {
                string query = @"
                    SELECT Message, Seen
                    FROM Notifications
                    WHERE UserID = @UserID
                    ORDER BY Seen ASC, Date DESC
                ";
                return ExecuteQuery(query, new SqlParameter("@UserID", userID));
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error loading notifications: " + ex.Message);
                return null;
            }
        }

        public int GetNotificationCountByUserID(int userID)
        {
            try
            {
                string query = "SELECT COUNT(*) AS Total FROM Notifications WHERE UserID = @UserID AND Seen = 0";

                SqlParameter[] parameters = {
                    new SqlParameter("@UserID", userID)
                };

                DataTable dt = ExecuteQuery(query, parameters);

                int unseenCount = 0;
                if (dt != null && dt.Rows.Count > 0)
                {
                    unseenCount = Convert.ToInt32(dt.Rows[0]["Total"]);
                }

                return unseenCount;
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error counting notifications: " + ex.Message);
                return 0;
            }
        }

        public bool SeenAllNotifications(int userID)
        {
            try
            {
                string query = "UPDATE Notifications SET Seen = 1 WHERE UserID = @UserID AND Seen = 0";
                ExecuteNonQuery(query, new SqlParameter("@UserID", userID));
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxHelper.ShowError("Error updating notifications: " + ex.Message);
                return false;
            }
        }
    }
}
