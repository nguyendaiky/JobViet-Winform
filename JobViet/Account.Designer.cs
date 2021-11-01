
namespace JobVietApp
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnl_Modify = new System.Windows.Forms.Panel();
            this.pnl_Name_Modify = new System.Windows.Forms.Panel();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Address_Modify = new System.Windows.Forms.Panel();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_Sex_Modify = new System.Windows.Forms.Panel();
            this.cb_Sex = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_Phone_Modify = new System.Windows.Forms.Panel();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnl_Save = new System.Windows.Forms.Panel();
            this.pnl_Name_Save = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.pnl_Address_Save = new System.Windows.Forms.Panel();
            this.lb_Address = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_Sex_Save = new System.Windows.Forms.Panel();
            this.lb_Sex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_Phone_Save = new System.Windows.Forms.Panel();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bnt_Save = new System.Windows.Forms.Button();
            this.pic_avatar = new JobVietApp.CircularPictureBox();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.lb_Activity = new System.Windows.Forms.Label();
            this.lb_Home = new System.Windows.Forms.Label();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.pic_Activity = new System.Windows.Forms.PictureBox();
            this.pic_Account = new System.Windows.Forms.PictureBox();
            this.circularPictureBox1 = new JobVietApp.CircularPictureBox();
            this.title = new System.Windows.Forms.Label();
            this.lb_Account = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_Modify.SuspendLayout();
            this.pnl_Name_Modify.SuspendLayout();
            this.pnl_Address_Modify.SuspendLayout();
            this.pnl_Sex_Modify.SuspendLayout();
            this.pnl_Phone_Modify.SuspendLayout();
            this.pnl_Save.SuspendLayout();
            this.pnl_Name_Save.SuspendLayout();
            this.pnl_Address_Save.SuspendLayout();
            this.pnl_Sex_Save.SuspendLayout();
            this.pnl_Phone_Save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Activity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.pnl_Modify);
            this.panel1.Controls.Add(this.pnl_Save);
            this.panel1.Controls.Add(this.bnt_Save);
            this.panel1.Controls.Add(this.pic_avatar);
            this.panel1.Controls.Add(this.btn_Modify);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 433);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JobVietApp.Properties.Settings.Default, "lb_change_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.label3.ForeColor = global::JobVietApp.Properties.Settings.Default.lb_change_color;
            this.label3.Location = new System.Drawing.Point(80, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đổi màu chủ đạo:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Green",
            "Orange",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(178, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pnl_Modify
            // 
            this.pnl_Modify.Controls.Add(this.pnl_Name_Modify);
            this.pnl_Modify.Controls.Add(this.pnl_Address_Modify);
            this.pnl_Modify.Controls.Add(this.pnl_Sex_Modify);
            this.pnl_Modify.Controls.Add(this.pnl_Phone_Modify);
            this.pnl_Modify.Location = new System.Drawing.Point(30, 122);
            this.pnl_Modify.Name = "pnl_Modify";
            this.pnl_Modify.Size = new System.Drawing.Size(284, 241);
            this.pnl_Modify.TabIndex = 5;
            // 
            // pnl_Name_Modify
            // 
            this.pnl_Name_Modify.BackColor = global::JobVietApp.Properties.Settings.Default.change_backcolor;
            this.pnl_Name_Modify.Controls.Add(this.txt_Name);
            this.pnl_Name_Modify.Controls.Add(this.label2);
            this.pnl_Name_Modify.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_backcolor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnl_Name_Modify.Location = new System.Drawing.Point(11, 3);
            this.pnl_Name_Modify.Name = "pnl_Name_Modify";
            this.pnl_Name_Modify.Size = new System.Drawing.Size(260, 52);
            this.pnl_Name_Modify.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(122, 17);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(117, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và Tên:";
            // 
            // pnl_Address_Modify
            // 
            this.pnl_Address_Modify.BackColor = global::JobVietApp.Properties.Settings.Default.change_backcolor;
            this.pnl_Address_Modify.Controls.Add(this.txt_Address);
            this.pnl_Address_Modify.Controls.Add(this.label8);
            this.pnl_Address_Modify.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_backcolor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnl_Address_Modify.Location = new System.Drawing.Point(12, 177);
            this.pnl_Address_Modify.Name = "pnl_Address_Modify";
            this.pnl_Address_Modify.Size = new System.Drawing.Size(260, 52);
            this.pnl_Address_Modify.TabIndex = 4;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(122, 17);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(117, 20);
            this.txt_Address.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ:";
            // 
            // pnl_Sex_Modify
            // 
            this.pnl_Sex_Modify.BackColor = global::JobVietApp.Properties.Settings.Default.change_backcolor;
            this.pnl_Sex_Modify.Controls.Add(this.cb_Sex);
            this.pnl_Sex_Modify.Controls.Add(this.label9);
            this.pnl_Sex_Modify.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_backcolor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnl_Sex_Modify.Location = new System.Drawing.Point(12, 61);
            this.pnl_Sex_Modify.Name = "pnl_Sex_Modify";
            this.pnl_Sex_Modify.Size = new System.Drawing.Size(260, 52);
            this.pnl_Sex_Modify.TabIndex = 2;
            // 
            // cb_Sex
            // 
            this.cb_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sex.FormattingEnabled = true;
            this.cb_Sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cb_Sex.Location = new System.Drawing.Point(122, 17);
            this.cb_Sex.Name = "cb_Sex";
            this.cb_Sex.Size = new System.Drawing.Size(117, 21);
            this.cb_Sex.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Giới tính:";
            // 
            // pnl_Phone_Modify
            // 
            this.pnl_Phone_Modify.BackColor = global::JobVietApp.Properties.Settings.Default.change_backcolor;
            this.pnl_Phone_Modify.Controls.Add(this.txt_Phone);
            this.pnl_Phone_Modify.Controls.Add(this.label11);
            this.pnl_Phone_Modify.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_backcolor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnl_Phone_Modify.Location = new System.Drawing.Point(12, 119);
            this.pnl_Phone_Modify.Name = "pnl_Phone_Modify";
            this.pnl_Phone_Modify.Size = new System.Drawing.Size(260, 52);
            this.pnl_Phone_Modify.TabIndex = 3;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(122, 17);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(117, 20);
            this.txt_Phone.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số điện thoại:";
            // 
            // pnl_Save
            // 
            this.pnl_Save.Controls.Add(this.pnl_Name_Save);
            this.pnl_Save.Controls.Add(this.pnl_Address_Save);
            this.pnl_Save.Controls.Add(this.pnl_Sex_Save);
            this.pnl_Save.Controls.Add(this.pnl_Phone_Save);
            this.pnl_Save.Location = new System.Drawing.Point(30, 125);
            this.pnl_Save.Name = "pnl_Save";
            this.pnl_Save.Size = new System.Drawing.Size(284, 241);
            this.pnl_Save.TabIndex = 0;
            // 
            // pnl_Name_Save
            // 
            this.pnl_Name_Save.BackColor = global::JobVietApp.Properties.Settings.Default.change_backcolor;
            this.pnl_Name_Save.Controls.Add(this.label1);
            this.pnl_Name_Save.Controls.Add(this.lb_Name);
            this.pnl_Name_Save.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_backcolor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnl_Name_Save.Location = new System.Drawing.Point(11, 3);
            this.pnl_Name_Save.Name = "pnl_Name_Save";
            this.pnl_Name_Save.Size = new System.Drawing.Size(260, 52);
            this.pnl_Name_Save.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Họ và Tên:";
            // 
            // lb_Name
            // 
            this.lb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.Location = new System.Drawing.Point(119, 18);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(124, 16);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "Nguyễn Đại Kỳ";
            // 
            // pnl_Address_Save
            // 
            this.pnl_Address_Save.BackColor = global::JobVietApp.Properties.Settings.Default.change_backcolor;
            this.pnl_Address_Save.Controls.Add(this.lb_Address);
            this.pnl_Address_Save.Controls.Add(this.label7);
            this.pnl_Address_Save.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_backcolor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnl_Address_Save.Location = new System.Drawing.Point(11, 177);
            this.pnl_Address_Save.Name = "pnl_Address_Save";
            this.pnl_Address_Save.Size = new System.Drawing.Size(260, 52);
            this.pnl_Address_Save.TabIndex = 4;
            // 
            // lb_Address
            // 
            this.lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(119, 18);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(124, 16);
            this.lb_Address.TabIndex = 1;
            this.lb_Address.Text = "TP Hồ Chí Minh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // pnl_Sex_Save
            // 
            this.pnl_Sex_Save.BackColor = global::JobVietApp.Properties.Settings.Default.change_backcolor;
            this.pnl_Sex_Save.Controls.Add(this.lb_Sex);
            this.pnl_Sex_Save.Controls.Add(this.label4);
            this.pnl_Sex_Save.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_backcolor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnl_Sex_Save.Location = new System.Drawing.Point(11, 61);
            this.pnl_Sex_Save.Name = "pnl_Sex_Save";
            this.pnl_Sex_Save.Size = new System.Drawing.Size(260, 52);
            this.pnl_Sex_Save.TabIndex = 2;
            // 
            // lb_Sex
            // 
            this.lb_Sex.AutoSize = true;
            this.lb_Sex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sex.Location = new System.Drawing.Point(119, 18);
            this.lb_Sex.Name = "lb_Sex";
            this.lb_Sex.Size = new System.Drawing.Size(37, 16);
            this.lb_Sex.TabIndex = 1;
            this.lb_Sex.Text = "Nam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính:";
            // 
            // pnl_Phone_Save
            // 
            this.pnl_Phone_Save.BackColor = global::JobVietApp.Properties.Settings.Default.change_backcolor;
            this.pnl_Phone_Save.Controls.Add(this.lb_Phone);
            this.pnl_Phone_Save.Controls.Add(this.label6);
            this.pnl_Phone_Save.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_backcolor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pnl_Phone_Save.Location = new System.Drawing.Point(11, 119);
            this.pnl_Phone_Save.Name = "pnl_Phone_Save";
            this.pnl_Phone_Save.Size = new System.Drawing.Size(260, 52);
            this.pnl_Phone_Save.TabIndex = 3;
            // 
            // lb_Phone
            // 
            this.lb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.Location = new System.Drawing.Point(119, 18);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(124, 16);
            this.lb_Phone.TabIndex = 1;
            this.lb_Phone.Text = "0123456789";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại:";
            // 
            // bnt_Save
            // 
            this.bnt_Save.AutoSize = true;
            this.bnt_Save.BackColor = global::JobVietApp.Properties.Settings.Default.change_background_support;
            this.bnt_Save.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_background_support", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bnt_Save.FlatAppearance.BorderSize = 0;
            this.bnt_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Save.Location = new System.Drawing.Point(39, 384);
            this.bnt_Save.Name = "bnt_Save";
            this.bnt_Save.Size = new System.Drawing.Size(127, 38);
            this.bnt_Save.TabIndex = 6;
            this.bnt_Save.Text = " Lưu thông tin";
            this.bnt_Save.UseVisualStyleBackColor = false;
            this.bnt_Save.Click += new System.EventHandler(this.bnt_Save_Click);
            // 
            // pic_avatar
            // 
            this.pic_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pic_avatar.BackgroundImage = global::JobVietApp.Properties.Resources._99127089_1136004756766400_8261023067304624128_o1;
            this.pic_avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_avatar.Location = new System.Drawing.Point(131, 3);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(64, 64);
            this.pic_avatar.TabIndex = 0;
            this.pic_avatar.TabStop = false;
            this.pic_avatar.Click += new System.EventHandler(this.pic_avatar_Click);
            // 
            // btn_Modify
            // 
            this.btn_Modify.AutoSize = true;
            this.btn_Modify.BackColor = global::JobVietApp.Properties.Settings.Default.change_background_support;
            this.btn_Modify.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::JobVietApp.Properties.Settings.Default, "change_background_support", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btn_Modify.FlatAppearance.BorderSize = 0;
            this.btn_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modify.Location = new System.Drawing.Point(172, 384);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(127, 38);
            this.btn_Modify.TabIndex = 5;
            this.btn_Modify.Text = "Chỉnh sửa thông tin";
            this.btn_Modify.UseVisualStyleBackColor = false;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // lb_Activity
            // 
            this.lb_Activity.AutoSize = true;
            this.lb_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Activity.ForeColor = System.Drawing.Color.Gray;
            this.lb_Activity.Location = new System.Drawing.Point(136, 527);
            this.lb_Activity.Name = "lb_Activity";
            this.lb_Activity.Size = new System.Drawing.Size(77, 18);
            this.lb_Activity.TabIndex = 7;
            this.lb_Activity.Text = "Hoạt động";
            this.lb_Activity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Home
            // 
            this.lb_Home.AutoSize = true;
            this.lb_Home.BackColor = System.Drawing.Color.Transparent;
            this.lb_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Home.ForeColor = System.Drawing.Color.Gray;
            this.lb_Home.Location = new System.Drawing.Point(27, 526);
            this.lb_Home.Name = "lb_Home";
            this.lb_Home.Size = new System.Drawing.Size(74, 18);
            this.lb_Home.TabIndex = 9;
            this.lb_Home.Text = "Trang chủ";
            this.lb_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_Home
            // 
            this.pic_Home.BackColor = System.Drawing.Color.Transparent;
            this.pic_Home.BackgroundImage = global::JobVietApp.Properties.Resources.home_gray;
            this.pic_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Home.Location = new System.Drawing.Point(39, 477);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Size = new System.Drawing.Size(46, 46);
            this.pic_Home.TabIndex = 8;
            this.pic_Home.TabStop = false;
            this.pic_Home.Click += new System.EventHandler(this.pic_Home_Click);
            // 
            // pic_Activity
            // 
            this.pic_Activity.BackColor = System.Drawing.Color.Transparent;
            this.pic_Activity.BackgroundImage = global::JobVietApp.Properties.Resources.list_gray;
            this.pic_Activity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Activity.Location = new System.Drawing.Point(148, 478);
            this.pic_Activity.Name = "pic_Activity";
            this.pic_Activity.Size = new System.Drawing.Size(46, 46);
            this.pic_Activity.TabIndex = 6;
            this.pic_Activity.TabStop = false;
            this.pic_Activity.Click += new System.EventHandler(this.pic_Activity_Click);
            // 
            // pic_Account
            // 
            this.pic_Account.BackColor = System.Drawing.Color.Transparent;
            this.pic_Account.BackgroundImage = global::JobVietApp.Properties.Resources.account_green;
            this.pic_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Account.Location = new System.Drawing.Point(253, 478);
            this.pic_Account.Name = "pic_Account";
            this.pic_Account.Size = new System.Drawing.Size(46, 46);
            this.pic_Account.TabIndex = 1;
            this.pic_Account.TabStop = false;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.circularPictureBox1.BackgroundImage = global::JobVietApp.Properties.Resources.closecircle_120264;
            this.circularPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circularPictureBox1.Location = new System.Drawing.Point(304, -4);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(36, 36);
            this.circularPictureBox1.TabIndex = 2;
            this.circularPictureBox1.TabStop = false;
            this.circularPictureBox1.Click += new System.EventHandler(this.circularPictureBox1_Click);
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
            this.title.TabIndex = 10;
            this.title.Text = "JobViet";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lb_Account
            // 
            this.lb_Account.AutoSize = true;
            this.lb_Account.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::JobVietApp.Properties.Settings.Default, "lb_change_color", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Account.ForeColor = global::JobVietApp.Properties.Settings.Default.lb_change_color;
            this.lb_Account.Location = new System.Drawing.Point(241, 527);
            this.lb_Account.Name = "lb_Account";
            this.lb_Account.Size = new System.Drawing.Size(73, 18);
            this.lb_Account.TabIndex = 3;
            this.lb_Account.Text = "Tài khoản";
            this.lb_Account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Account.ForeColorChanged += new System.EventHandler(this.lb_Account_ForeColorChanged);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(339, 553);
            this.Controls.Add(this.title);
            this.Controls.Add(this.lb_Home);
            this.Controls.Add(this.pic_Home);
            this.Controls.Add(this.lb_Activity);
            this.Controls.Add(this.pic_Activity);
            this.Controls.Add(this.lb_Account);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_Account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Modify.ResumeLayout(false);
            this.pnl_Name_Modify.ResumeLayout(false);
            this.pnl_Name_Modify.PerformLayout();
            this.pnl_Address_Modify.ResumeLayout(false);
            this.pnl_Address_Modify.PerformLayout();
            this.pnl_Sex_Modify.ResumeLayout(false);
            this.pnl_Sex_Modify.PerformLayout();
            this.pnl_Phone_Modify.ResumeLayout(false);
            this.pnl_Phone_Modify.PerformLayout();
            this.pnl_Save.ResumeLayout(false);
            this.pnl_Name_Save.ResumeLayout(false);
            this.pnl_Name_Save.PerformLayout();
            this.pnl_Address_Save.ResumeLayout(false);
            this.pnl_Address_Save.PerformLayout();
            this.pnl_Sex_Save.ResumeLayout(false);
            this.pnl_Sex_Save.PerformLayout();
            this.pnl_Phone_Save.ResumeLayout(false);
            this.pnl_Phone_Save.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Activity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.PictureBox pic_Account;
        private System.Windows.Forms.Label lb_Address;
        private CircularPictureBox pic_avatar;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Button bnt_Save;
        private System.Windows.Forms.Label lb_Sex;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Sex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label11;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Label lb_Account;
        private System.Windows.Forms.Label lb_Activity;
        private System.Windows.Forms.PictureBox pic_Activity;
        private System.Windows.Forms.Label lb_Home;
        private System.Windows.Forms.PictureBox pic_Home;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnl_Modify;
        private System.Windows.Forms.Panel pnl_Name_Modify;
        private System.Windows.Forms.Panel pnl_Address_Modify;
        private System.Windows.Forms.Panel pnl_Sex_Modify;
        private System.Windows.Forms.Panel pnl_Phone_Modify;
        private System.Windows.Forms.Panel pnl_Save;
        private System.Windows.Forms.Panel pnl_Name_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Address_Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnl_Sex_Save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_Phone_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

