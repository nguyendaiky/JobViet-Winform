
namespace JobVietApp
{
    partial class Activity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity));
            this.lb_Home = new System.Windows.Forms.Label();
            this.lb_Activity = new System.Windows.Forms.Label();
            this.lb_Account = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.lv_Activity = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.pic_Activity = new System.Windows.Forms.PictureBox();
            this.pic_Account = new System.Windows.Forms.PictureBox();
            this.circularPictureBox1 = new JobVietApp.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Activity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Home
            // 
            this.lb_Home.AutoSize = true;
            this.lb_Home.BackColor = System.Drawing.Color.Transparent;
            this.lb_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Home.ForeColor = System.Drawing.Color.Gray;
            this.lb_Home.Location = new System.Drawing.Point(24, 526);
            this.lb_Home.Name = "lb_Home";
            this.lb_Home.Size = new System.Drawing.Size(74, 18);
            this.lb_Home.TabIndex = 17;
            this.lb_Home.Text = "Trang chủ";
            this.lb_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Activity
            // 
            this.lb_Activity.AutoSize = true;
            this.lb_Activity.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JobVietApp.Properties.Settings.Default, "lb_change_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Activity.ForeColor = global::JobVietApp.Properties.Settings.Default.lb_change_color;
            this.lb_Activity.Location = new System.Drawing.Point(130, 527);
            this.lb_Activity.Name = "lb_Activity";
            this.lb_Activity.Size = new System.Drawing.Size(77, 18);
            this.lb_Activity.TabIndex = 15;
            this.lb_Activity.Text = "Hoạt động";
            this.lb_Activity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Activity.ForeColorChanged += new System.EventHandler(this.lb_Activity_ForeColorChanged);
            // 
            // lb_Account
            // 
            this.lb_Account.AutoSize = true;
            this.lb_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Account.ForeColor = System.Drawing.Color.Gray;
            this.lb_Account.Location = new System.Drawing.Point(240, 527);
            this.lb_Account.Name = "lb_Account";
            this.lb_Account.Size = new System.Drawing.Size(73, 18);
            this.lb_Account.TabIndex = 11;
            this.lb_Account.Text = "Tài khoản";
            this.lb_Account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JobVietApp.Properties.Settings.Default, "lb_change_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.title.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = global::JobVietApp.Properties.Settings.Default.lb_change_color;
            this.title.Location = new System.Drawing.Point(128, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(81, 29);
            this.title.TabIndex = 18;
            this.title.Text = "JobViet";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lv_Activity
            // 
            this.lv_Activity.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lv_Activity.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JobVietApp.Properties.Settings.Default, "lb_change_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lv_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Activity.ForeColor = global::JobVietApp.Properties.Settings.Default.lb_change_color;
            this.lv_Activity.FullRowSelect = true;
            this.lv_Activity.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Activity.HideSelection = false;
            this.lv_Activity.Location = new System.Drawing.Point(-1, 36);
            this.lv_Activity.MultiSelect = false;
            this.lv_Activity.Name = "lv_Activity";
            this.lv_Activity.Size = new System.Drawing.Size(341, 307);
            this.lv_Activity.TabIndex = 19;
            this.lv_Activity.UseCompatibleStateImageBehavior = false;
            this.lv_Activity.View = System.Windows.Forms.View.Details;
            this.lv_Activity.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_Activity_ItemSelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JobVietApp.Properties.Settings.Default, "lb_change_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::JobVietApp.Properties.Settings.Default.lb_change_color;
            this.label1.Location = new System.Drawing.Point(24, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã khuyến mãi:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "KHUYENMAI20";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JobVietApp.Properties.Settings.Default, "lb_change_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::JobVietApp.Properties.Settings.Default.lb_change_color;
            this.label2.Location = new System.Drawing.Point(24, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Số tiền phải thanh toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JobVietApp.Properties.Settings.Default, "change_background_support", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = global::JobVietApp.Properties.Settings.Default.change_background_support;
            this.label3.Location = new System.Drawing.Point(166, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "0đ";
            // 
            // button1
            // 
            this.button1.BackColor = global::JobVietApp.Properties.Settings.Default.change_background_support;
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_background_support", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(186, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 35);
            this.button1.TabIndex = 72;
            this.button1.Text = "Thanh toán";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(37, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 73;
            this.button2.Text = "Xóa tất cả";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pic_Home
            // 
            this.pic_Home.BackColor = System.Drawing.Color.Transparent;
            this.pic_Home.BackgroundImage = global::JobVietApp.Properties.Resources.home_gray;
            this.pic_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Home.Location = new System.Drawing.Point(37, 478);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Size = new System.Drawing.Size(46, 46);
            this.pic_Home.TabIndex = 16;
            this.pic_Home.TabStop = false;
            this.pic_Home.Click += new System.EventHandler(this.pic_Home_Click);
            // 
            // pic_Activity
            // 
            this.pic_Activity.BackColor = System.Drawing.Color.Transparent;
            this.pic_Activity.BackgroundImage = global::JobVietApp.Properties.Resources.list_green;
            this.pic_Activity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Activity.Location = new System.Drawing.Point(145, 478);
            this.pic_Activity.Name = "pic_Activity";
            this.pic_Activity.Size = new System.Drawing.Size(46, 46);
            this.pic_Activity.TabIndex = 14;
            this.pic_Activity.TabStop = false;
            // 
            // pic_Account
            // 
            this.pic_Account.BackColor = System.Drawing.Color.Transparent;
            this.pic_Account.BackgroundImage = global::JobVietApp.Properties.Resources.account_gray;
            this.pic_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Account.Location = new System.Drawing.Point(255, 478);
            this.pic_Account.Name = "pic_Account";
            this.pic_Account.Size = new System.Drawing.Size(46, 46);
            this.pic_Account.TabIndex = 10;
            this.pic_Account.TabStop = false;
            this.pic_Account.Click += new System.EventHandler(this.pic_Account_Click);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.BackgroundImage = global::JobVietApp.Properties.Resources.closecircle_120264;
            this.circularPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularPictureBox1.Location = new System.Drawing.Point(304, -4);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(36, 36);
            this.circularPictureBox1.TabIndex = 3;
            this.circularPictureBox1.TabStop = false;
            this.circularPictureBox1.Click += new System.EventHandler(this.circularPictureBox1_Click);
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(339, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_Activity);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lb_Home);
            this.Controls.Add(this.pic_Home);
            this.Controls.Add(this.lb_Activity);
            this.Controls.Add(this.pic_Activity);
            this.Controls.Add(this.lb_Account);
            this.Controls.Add(this.pic_Account);
            this.Controls.Add(this.circularPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Activity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Activity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label lb_Home;
        private System.Windows.Forms.PictureBox pic_Home;
        private System.Windows.Forms.Label lb_Activity;
        private System.Windows.Forms.PictureBox pic_Activity;
        private System.Windows.Forms.Label lb_Account;
        private System.Windows.Forms.PictureBox pic_Account;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ListView lv_Activity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}