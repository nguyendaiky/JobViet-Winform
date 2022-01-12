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

namespace JobVietApp
{
    public partial class Home_vsMayLanh : Form
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
        public Home_vsMayLanh()
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
        double tinh_gia(string chatluong,string loai)
        {
            //Treo tường, dưới 2HP
            //Treo tường, trên 2HP
            //Tủ đứng
            //Âm trần, dưới 3HP
            //Âm trần, trên 3HP
            double gia = 0;
            if (loai == "Treo tường, dưới 2HP")
            {
                gia += 180000;
            }
            else if (loai == "Treo tường, trên 2HP")
            {
                gia += 200000;
            }
            else if (loai == "Tủ đứng")
            {
                gia += 300000;
            }
            else if (loai == "Âm trần, dưới 3HP")
            {
                gia += 360000;
            }
            else if (loai == "Âm trần, trên 3HP")
            {
                gia += 540000;
            }

            if (chatluong == "⭐⭐⭐⭐⭐")
            {
                gia += 30000;
            }
            else if (chatluong == "⭐⭐⭐⭐")
            {
                gia += 20000;
            }
            else if (chatluong == "⭐⭐⭐")
            {
                gia += 10000;
            }
            return gia;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ngay = dateTimePicker1.Value.ToString();
            ngay = ngay.Split()[0];
            string gio = textBox1.Text;
            string diachi = richTextBox1.Text;
            string giotinh = comboBox1.Text;
            string dotuoi = comboBox2.Text;
            string chatluong = comboBox3.Text;
            string loai = comboBox4.Text;
            double gia = tinh_gia(chatluong,loai);
            int soluong = Convert.ToInt32(numericUpDown1.Value);
            if (soluong == 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
            }
            else
            {
                string id = ShareVar.id_vsMayLanh.ToString();
                ShareVar.id_vsMayLanh++;
                ShareVar.data.Rows.Add("Vệ sinh máy lạnh " + id, ngay, gio, diachi, giotinh, dotuoi, chatluong, gia, 0, soluong, loai);
                MessageBox.Show("Xác nhận thành công!");
                Home.ActivityForm.AddListView();
                this.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chatluong = comboBox3.Text;
            string loai = comboBox4.Text;
            double gia = tinh_gia(chatluong,loai);
            label12.Text = gia.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chatluong = comboBox3.Text;
            string loai = comboBox4.Text;
            double gia = tinh_gia(chatluong, loai);
            label12.Text = gia.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            map m = new map();
            m.ShowDialog();
            richTextBox1.Text = ShareVar.address;
        }
    }
}
