﻿using System;
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
    public partial class Home_DiCho : Form
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
        public Home_DiCho()
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
        double tinh_gia(string chatluong)
        {
            double gia = 0;
            if (chatluong == "⭐⭐⭐⭐⭐")
            {
                gia = 200000;
            }
            else if (chatluong == "⭐⭐⭐⭐")
            {
                gia = 150000;
            }
            else if (chatluong == "⭐⭐⭐")
            {
                gia = 100000;
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
            double gia = tinh_gia(chatluong);
            int sogio = Convert.ToInt32(numericUpDown1.Value);
            string ghichu = richTextBox2.Text;
            if (sogio == 0)
            {
                MessageBox.Show("Số giờ làm không hợp lệ!");
            }
            else
            {
                string id = ShareVar.id_DiCho.ToString();
                ShareVar.id_DiCho++;
                ShareVar.data.Rows.Add("Đi chợ " + id, ngay, gio, diachi, giotinh, dotuoi, chatluong, gia, 0, sogio, ghichu);
                MessageBox.Show("Xác nhận thành công!");
                Home.ActivityForm.AddListView();
                this.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chatluong = comboBox3.Text;
            double gia = tinh_gia(chatluong);
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
