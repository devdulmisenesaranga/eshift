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
    public interface INotificationRepository
    {
        DataTable GetAllNotificationsByUserID(int userID);
        int GetNotificationCountByUserID(int userID);
        bool SeenAllNotifications(int userID);
    }
}
