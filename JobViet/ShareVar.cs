using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobVietApp
{
    public class ShareVar
    {
        public static Image HomeImageGreen = global::JobVietApp.Properties.Resources.home_green;
        public static Image HomeImageOrange = global::JobVietApp.Properties.Resources.home_orange;
        public static Image HomeImageBlue = global::JobVietApp.Properties.Resources.home_blue;

        public static Image AccountImageGreen = global::JobVietApp.Properties.Resources.account_green;
        public static Image AccountImageOrange = global::JobVietApp.Properties.Resources.account_orange;
        public static Image AccountImageBlue = global::JobVietApp.Properties.Resources.account_blue;

        public static Color Green = System.Drawing.Color.SpringGreen;
        public static Color Green_support = System.Drawing.Color.MediumTurquoise;

        public static Color Orange = System.Drawing.Color.DarkOrange;
        public static Color Orange_support = System.Drawing.Color.Gold;

        public static Color Blue = System.Drawing.Color.RoyalBlue;
        public static Color Blue_support = System.Drawing.Color.SkyBlue;

        public static DataTable data = new DataTable();
        public static void init_datatable()
        {
            ShareVar.data.Columns.Add("ten", typeof(string));
            ShareVar.data.Columns.Add("ngay", typeof(string));
            ShareVar.data.Columns.Add("gio", typeof(string));
            ShareVar.data.Columns.Add("diachi", typeof(string));
            ShareVar.data.Columns.Add("gioitinh", typeof(string));
            ShareVar.data.Columns.Add("dotuoi", typeof(string));
            ShareVar.data.Columns.Add("chatluong", typeof(string));
            ShareVar.data.Columns.Add("gia", typeof(double));
            ShareVar.data.Columns.Add("phuphi", typeof(double));
            ShareVar.data.Columns.Add("sl/gio", typeof(int));
            ShareVar.data.Columns.Add("ghichu", typeof(string));
        }

        public static int id_DiCho = 1;
        public static int id_DonDep = 1;
        public static int id_NauAn = 1;
        public static int id_GiatUi = 1;
        public static int id_vsSofa = 1;
        public static int id_vsMayLanh = 1;

        public static string address;

        public static void account_show()
        {
            Home.AccountForm.Show();
        }
        public static void account_hide()
        {
            Home.AccountForm.Hide();
        }

        public static void activity_show()
        {
            Home.ActivityForm.Show();
        }
        public static void activity_hide()
        {
            Home.ActivityForm.Hide();
        }

    }
}
