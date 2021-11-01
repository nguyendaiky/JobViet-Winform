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
    public partial class Home_vsSofa : Form
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
        public Home_vsSofa()
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
        double tinh_gia(string chatluong, string loai, string chatlieu)
        {
            //Sofa nỉ / vải
            //Sofa da

            //Sofa 01 ghế
            //Sofa 02 ghế
            //Sofa 03 ghế
            //Ghế đẩu

            double gia = 0;
            if (chatlieu == "Sofa nỉ / vải")
            {
                gia += 30000;
            }
            else if (chatlieu == "Sofa da")
            {
                gia += 50000;
            }

            if (loai == "Sofa 01 ghế")
            {
                gia += 360000;
            }
            else if (loai == "Sofa 02 ghế")
            {
                gia += 450000;
            }
            else if (loai == "Sofa 03 ghế")
            {
                gia += 500000;
            }
            else if (loai == "Ghế đẩu")
            {
                gia += 50000;
            }

            if (chatluong == "⭐⭐⭐⭐⭐")
            {
                gia += 60000;
            }
            else if (chatluong == "⭐⭐⭐⭐")
            {
                gia += 40000;
            }
            else if (chatluong == "⭐⭐⭐")
            {
                gia += 20000;
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
            string chatlieu = comboBox4.Text;
            string loai = comboBox5.Text;
            double gia = tinh_gia(chatluong, loai, chatlieu);
            int soluong = Convert.ToInt32(numericUpDown1.Value);
            if (soluong == 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
            }
            else
            {
                string id = ShareVar.id_vsSofa.ToString();
                ShareVar.id_vsSofa++;
                ShareVar.data.Rows.Add("Vệ sinh sofa " + id, ngay, gio, diachi, giotinh, dotuoi, chatluong, gia, 0, soluong, chatlieu + " " + loai);
                MessageBox.Show("Xác nhận thành công!");
                Home.ActivityForm.AddListView();
                this.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chatluong = comboBox3.Text;
            string chatlieu = comboBox4.Text;
            string loai = comboBox5.Text;
            double gia = tinh_gia(chatluong, loai, chatlieu);
            label12.Text = gia.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chatluong = comboBox3.Text;
            string chatlieu = comboBox4.Text;
            string loai = comboBox5.Text;
            double gia = tinh_gia(chatluong, loai, chatlieu);
            label12.Text = gia.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chatluong = comboBox3.Text;
            string chatlieu = comboBox4.Text;
            string loai = comboBox5.Text;
            double gia = tinh_gia(chatluong, loai, chatlieu);
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
