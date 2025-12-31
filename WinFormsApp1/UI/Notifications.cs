using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data.Repositories;
using WinFormsApp1.Helpers;
using WinFormsApp1.Utils;

namespace WinFormsApp1.UI
{
    public partial class Notifications : Form
    {
        //Action for track close event of notification tab
        public event Action OnClose;
        public Notifications()
        {
            InitializeComponent();
            StyleTable();
            LoadNotifications();
        }

        private void StyleTable()
        {
            TableStyler.ApplyStyle(dgvNotifications);
        }

        //Load all notifications
        private void LoadNotifications()
        {
            DataTable dt = new NotificationRepository().GetAllNotificationsByUserID(Properties.Settings.Default.UserID);
            dgvNotifications.DataSource = dt;
        }

        //Update all notifications to mark as read
        private void SeenAllNotifications()
        {
            new NotificationRepository().SeenAllNotifications(Properties.Settings.Default.UserID);
            OnClose?.Invoke();
        }

        private void Notifications_FormClosed(object sender, FormClosedEventArgs e)
        {
            //When closing the popup.. mark all notifications as read..
            SeenAllNotifications();
        }
    }
}
