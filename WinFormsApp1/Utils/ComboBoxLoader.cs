using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Helpers;

namespace WinFormsApp1.Utils
{
    public class ComboBoxLoader
    {
        public static void LoadValueOnly(ComboBox comboBox, DataTable dt, string displayField)
        {
            comboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboBox.Items.Add(row[displayField].ToString());
            }
        }

    }
}
