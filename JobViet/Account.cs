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
using System.Threading;

namespace JobVietApp
{
    public partial class Account : Form
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
        public Account()
        {
            ShowInTaskbar = false;
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnl_Modify.Visible = false;
        }

        private void pic_avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic_avatar.BackgroundImage = new Bitmap(open.FileName);
                pic_avatar.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            txt_Name.Text = lb_Name.Text;
            cb_Sex.Text = lb_Sex.Text;
            txt_Phone.Text = lb_Phone.Text;
            txt_Address.Text = lb_Address.Text;
            pnl_Modify.Visible = true;
        }

        private void bnt_Save_Click(object sender, EventArgs e)
        {
            if (pnl_Modify.Visible == true)
            {
                lb_Name.Text = txt_Name.Text;
                lb_Sex.Text = cb_Sex.Text;
                lb_Phone.Text = txt_Phone.Text;
                lb_Address.Text = txt_Address.Text;
                pnl_Modify.Visible = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_Name_Save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_Name_Save.Width, pnl_Name_Save.Height, 20, 20));
            pnl_Name_Modify.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_Name_Modify.Width, pnl_Name_Modify.Height, 20, 20));
            pnl_Sex_Save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_Sex_Save.Width, pnl_Sex_Save.Height, 20, 20));
            pnl_Sex_Modify.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_Sex_Modify.Width, pnl_Sex_Modify.Height, 20, 20));
            pnl_Phone_Save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_Phone_Save.Width, pnl_Phone_Save.Height, 20, 20));
            pnl_Phone_Modify.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_Phone_Modify.Width, pnl_Phone_Modify.Height, 20, 20));
            pnl_Address_Save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_Address_Save.Width, pnl_Address_Save.Height, 20, 20));
            pnl_Address_Modify.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnl_Address_Modify.Width, pnl_Address_Modify.Height, 20, 20));
            bnt_Save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, bnt_Save.Width, bnt_Save.Height, 20, 20));
            btn_Modify.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Modify.Width, bnt_Save.Height, 20, 20));
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_Home_Click(object sender, EventArgs e)
        {
            ShareVar.account_hide();
        }

        private void pic_Activity_Click(object sender, EventArgs e)
        {
            ShareVar.activity_show();
            ShareVar.account_hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.Text == "Orange")
            {
                Properties.Settings.Default.lb_change_color = ShareVar.Orange;
                Properties.Settings.Default.change_backcolor = ShareVar.Orange;
                Properties.Settings.Default.change_background_support = ShareVar.Orange_support;
            }
            else if (cb.Text == "Green")
            {
                Properties.Settings.Default.Reset();
            }
            else if (cb.Text == "Blue")
            {
                Properties.Settings.Default.lb_change_color = ShareVar.Blue;
                Properties.Settings.Default.change_backcolor = ShareVar.Blue;
                Properties.Settings.Default.change_background_support = ShareVar.Blue_support;
            }
        }

        private void lb_Account_ForeColorChanged(object sender, EventArgs e)
        {
            if (lb_Account.ForeColor == ShareVar.Orange)
            {
                pic_Account.BackgroundImage = global::JobVietApp.Properties.Resources.account_orange;
            }
            else if (lb_Account.ForeColor == ShareVar.Blue)
            {
                pic_Account.BackgroundImage = global::JobVietApp.Properties.Resources.account_blue;
            }
            else
            {
                pic_Account.BackgroundImage = global::JobVietApp.Properties.Resources.account_green;
            }
        }
    }
}
