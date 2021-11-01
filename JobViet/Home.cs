using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace JobVietApp
{
    public partial class Home : Form
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

        public static Activity ActivityForm = new Activity();
        public static Account AccountForm = new Account();

        public Home()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ShareVar.init_datatable();
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_Account_Click(object sender, EventArgs e)
        {
            ShareVar.account_show();
        }

        private void pic_Activity_Click(object sender, EventArgs e)
        {
            ShareVar.activity_show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pic_DonDep.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_DonDep.Width, pic_DonDep.Height, 20, 20));
            pic_GiatUi.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_GiatUi.Width, pic_GiatUi.Height, 20, 20));
            pic_DiCho.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_DiCho.Width, pic_DiCho.Height, 20, 20));
            pic_NauAn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_NauAn.Width, pic_NauAn.Height, 20, 20));
            pic_vsSofa.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_vsSofa.Width, pic_vsSofa.Height, 20, 20));
            pic_vsMayLanh.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pic_vsMayLanh.Width, pic_vsMayLanh.Height, 20, 20));
        }

        private void pic_DonDep_Click(object sender, EventArgs e)
        {
            Home_DonDep HomeDonDepForm = new Home_DonDep();
            HomeDonDepForm.ShowDialog();
        }

        private void pic_GiatUi_Click(object sender, EventArgs e)
        {
            Home_GiatUi HomeGiatUiForm = new Home_GiatUi();
            HomeGiatUiForm.ShowDialog();
        }

        private void pic_DiCho_Click(object sender, EventArgs e)
        {
            Home_DiCho HomeDiChoForm = new Home_DiCho();
            HomeDiChoForm.ShowDialog();
        }

        private void pic_NauAn_Click(object sender, EventArgs e)
        {
            Home_NauAn HomeNauAnForm = new Home_NauAn();
            HomeNauAnForm.ShowDialog();
        }

        private void pic_vsSofa_Click(object sender, EventArgs e)
        {
            Home_vsSofa HomevsSofaForm = new Home_vsSofa();
            HomevsSofaForm.ShowDialog();
        }

        private void pic_vsMayLanh_Click(object sender, EventArgs e)
        {
            Home_vsMayLanh HomevsMayLanhForm = new Home_vsMayLanh();
            HomevsMayLanhForm.ShowDialog();
        }

        private void lb_Home_ForeColorChanged(object sender, EventArgs e)
        {
            if (lb_Home.ForeColor == ShareVar.Orange)
            {
                pic_Home.BackgroundImage = global::JobVietApp.Properties.Resources.home_orange;
            }
            else if (lb_Home.ForeColor == ShareVar.Blue)
            {
                pic_Home.BackgroundImage = global::JobVietApp.Properties.Resources.home_blue;
            }
            else
            {
                pic_Home.BackgroundImage = global::JobVietApp.Properties.Resources.home_green;
            }
        }
    }
}
