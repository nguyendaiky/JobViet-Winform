using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;

namespace JobVietApp
{
    public partial class map : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public map()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void map_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMapProviders.GoogleMap;
            gmap.DragButton = MouseButtons.Left;
            double lat = 10.762622;
            double longt = 106.660172;
            gmap.Position = new GMap.NET.PointLatLng(lat,longt);
            gmap.SetPositionByKeywords("Ho Chi Minh City, Vietnam");
            gmap.MinZoom = 10;
            gmap.MaxZoom = 100;
            gmap.Zoom = 15;
            ShareVar.address = richTextBox1.Text;
        }

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var point = gmap.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;
                gmap.Position = point;
                ShareVar.address = richTextBox1.Text;
                string result = FindAddress(point);
                if (result != "")
                {
                    richTextBox1.Text = result;
                }
                ShareVar.address = richTextBox1.Text;
            }
        }

        public static string FindAddress(PointLatLng pnt, bool fullinfo = false)
        {
            string ret = "";
            GeoCoderStatusCode status;
            var pos = GMapProviders.GoogleMap.GetPlacemark(pnt, out status);
            if (status == GeoCoderStatusCode.OK && pos != null)
            {
                ret = pos.Value.Address;
                if (fullinfo)
                    ret = pos.Value.ToString();
            }
            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
