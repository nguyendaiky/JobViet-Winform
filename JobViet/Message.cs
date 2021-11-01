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
    public partial class Message : Form
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
        public Message()
        {
            ShowInTaskbar = false;
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_Home_Click(object sender, EventArgs e)
        {
        }

        private void pic_Activity_Click(object sender, EventArgs e)
        {
            ShareVar.activity_show();
        }

        private void pic_Account_Click(object sender, EventArgs e)
        {
            ShareVar.account_show();
        }
    }
}
