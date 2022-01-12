using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace JobVietApp
{
    public partial class Activity : Form
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
        public Activity()
        {
            ShowInTaskbar = false;
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            LoadListView();
            label3.Text = tinh_tong_tien().ToString();
            button1.Enabled = false;
            button2.Enabled = false;
        }
        double tinh_tien(double gia, int sl, double phuphi)
        {
            double tien = 0;
            tien = gia * sl + phuphi;
            return tien;
        }
        ListViewItem create_item(string ten, double gia, double phuphi, int sl)
        {
            ListViewItem item1 = new ListViewItem(Text = ten);
            item1.SubItems.Add(gia.ToString());
            item1.SubItems.Add(phuphi.ToString());
            item1.SubItems.Add(sl.ToString());
            item1.SubItems.Add(tinh_tien(gia,sl,phuphi).ToString());
            return item1;
        }
        void LoadListView()
        {
            lv_Activity.View = View.Details;
            lv_Activity.Columns.Add("Tên việc làm");
            lv_Activity.Columns[0].Width = -2;
            lv_Activity.Columns.Add("Giá");
            lv_Activity.Columns[1].Width = -2;
            lv_Activity.Columns.Add("Phụ phí");
            lv_Activity.Columns[2].Width = -2;
            lv_Activity.Columns.Add("SL/Giờ");
            lv_Activity.Columns[3].Width = -2;
            lv_Activity.Columns.Add("Thành tiền");
            lv_Activity.Columns[4].Width = -2;
        }
        double tinh_tong_tien()
        {
            double tien = 0;
            foreach (ListViewItem item in lv_Activity.Items)
            {
                tien += Convert.ToDouble(item.SubItems[4].Text);
            }
            if (textBox1.Text == "KHUYENMAI10")
            {
                tien = tien - (tien * 10 / 100);
            }
            else if (textBox1.Text == "KHUYENMAI20")
            {
                tien = tien - (tien * 20 / 100);
            }
            else if (textBox1.Text == "KHUYENMAI30")
            {
                tien = tien - (tien * 30 / 100);
            }
            else if (textBox1.Text == "KHUYENMAI40")
            {
                tien = tien - (tien * 40 / 100);
            }
            else if (textBox1.Text == "KHUYENMAI50")
            {
                tien = tien - (tien * 50 / 100);
            }
            return tien;
        }
        public void AddListView()
        {
            lv_Activity.Items.Clear();
            foreach (DataRow dr in ShareVar.data.Rows)
            {
                string ten = dr["ten"].ToString();
                double gia = Convert.ToDouble(dr["gia"]);
                double phuphi = Convert.ToDouble(dr["phuphi"]);
                int sl = Convert.ToInt32(dr["sl/gio"]);
                ListViewItem item = create_item(ten, gia, phuphi, sl);
                lv_Activity.Items.Add(item);
            }
            label3.Text = tinh_tong_tien().ToString() + "đ";
            button1.Enabled = true;
            button2.Enabled = true;
        }
        private void circularPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_Home_Click(object sender, EventArgs e)
        {
            ShareVar.activity_hide();
        }

        private void pic_Account_Click(object sender, EventArgs e)
        {
            ShareVar.account_show();
            ShareVar.activity_hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công!");
            lv_Activity.Items.Clear();
            while (ShareVar.data.Rows.Count > 0)
            {
                ShareVar.data.Rows[0].Delete();
            }
            label3.Text = tinh_tong_tien().ToString() + "đ";
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = tinh_tong_tien().ToString() + "đ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công số tiền: " + tinh_tong_tien().ToString() + "đ");
            lv_Activity.Items.Clear();
            while (ShareVar.data.Rows.Count > 0)
            {
                ShareVar.data.Rows[0].Delete();
            }
            label3.Text = tinh_tong_tien().ToString() + "đ";
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void lb_Activity_ForeColorChanged(object sender, EventArgs e)
        {
            if (lb_Activity.ForeColor == ShareVar.Orange)
            {
                pic_Activity.BackgroundImage = global::JobVietApp.Properties.Resources.list_orange;
            }
            else if (lb_Activity.ForeColor == ShareVar.Blue)
            {
                pic_Activity.BackgroundImage = global::JobVietApp.Properties.Resources.list_blue;
            }
            else
            {
                pic_Activity.BackgroundImage = global::JobVietApp.Properties.Resources.list_green;
            }
        }

        private void lv_Activity_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lv_Activity.SelectedIndices.Count <= 0)
            {
                return;
            }
            int selectedindex = lv_Activity.SelectedIndices[0];
            if (selectedindex >= 0)
            {
                string text = lv_Activity.Items[selectedindex].Text;
                foreach (DataRow dr in ShareVar.data.Rows)
                {
                    if (dr["ten"].ToString() == text)
                    {
                        string ten = dr["ten"].ToString();
                        string ngay = dr["ngay"].ToString();
                        string gio = dr["gio"].ToString();
                        string diachi = dr["diachi"].ToString();
                        string gioitinh = dr["gioitinh"].ToString();
                        string dotuoi = dr["dotuoi"].ToString();
                        string chatluong = dr["chatluong"].ToString();
                        string ghichu = dr["ghichu"].ToString();
                        string text_show = String.Format("Ngày làm việc: {0}\nGiờ làm việc: {1}\nĐịa chỉ: {2}\nGiới tính: {3}\nĐộ tuổi: {4}\nChất lượng: {5}\nGhi chú:\n{6}", ngay, gio, diachi, gioitinh, dotuoi, chatluong, ghichu);
                        MessageBox.Show(text_show,ten);
                    }
                }
            }
        }
    }
}
