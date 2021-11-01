
namespace JobVietApp
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.lb_Home = new System.Windows.Forms.Label();
            this.lb_Activity = new System.Windows.Forms.Label();
            this.lb_Message = new System.Windows.Forms.Label();
            this.lb_Account = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.pic_Home = new System.Windows.Forms.PictureBox();
            this.pic_Activity = new System.Windows.Forms.PictureBox();
            this.pic_Message = new System.Windows.Forms.PictureBox();
            this.pic_Account = new System.Windows.Forms.PictureBox();
            this.circularPictureBox1 = new JobVietApp.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Activity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Message)).BeginInit();
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
            this.lb_Home.Location = new System.Drawing.Point(15, 527);
            this.lb_Home.Name = "lb_Home";
            this.lb_Home.Size = new System.Drawing.Size(74, 18);
            this.lb_Home.TabIndex = 17;
            this.lb_Home.Text = "Trang chủ";
            this.lb_Home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Activity
            // 
            this.lb_Activity.AutoSize = true;
            this.lb_Activity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Activity.ForeColor = System.Drawing.Color.Gray;
            this.lb_Activity.Location = new System.Drawing.Point(94, 527);
            this.lb_Activity.Name = "lb_Activity";
            this.lb_Activity.Size = new System.Drawing.Size(77, 18);
            this.lb_Activity.TabIndex = 15;
            this.lb_Activity.Text = "Hoạt động";
            this.lb_Activity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Message
            // 
            this.lb_Message.AutoSize = true;
            this.lb_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Message.ForeColor = System.Drawing.Color.SpringGreen;
            this.lb_Message.Location = new System.Drawing.Point(174, 527);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(67, 18);
            this.lb_Message.TabIndex = 13;
            this.lb_Message.Text = "Tin Nhắn";
            this.lb_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Account
            // 
            this.lb_Account.AutoSize = true;
            this.lb_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Account.ForeColor = System.Drawing.Color.Gray;
            this.lb_Account.Location = new System.Drawing.Point(253, 527);
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
            this.title.Font = new System.Drawing.Font("Microsoft Himalaya", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.SpringGreen;
            this.title.Location = new System.Drawing.Point(128, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(81, 29);
            this.title.TabIndex = 18;
            this.title.Text = "JobViet";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pic_Home
            // 
            this.pic_Home.BackColor = System.Drawing.Color.Transparent;
            this.pic_Home.BackgroundImage = global::JobVietApp.Properties.Resources.home_gray;
            this.pic_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Home.Location = new System.Drawing.Point(27, 478);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.Size = new System.Drawing.Size(46, 46);
            this.pic_Home.TabIndex = 16;
            this.pic_Home.TabStop = false;
            this.pic_Home.Click += new System.EventHandler(this.pic_Home_Click);
            // 
            // pic_Activity
            // 
            this.pic_Activity.BackColor = System.Drawing.Color.Transparent;
            this.pic_Activity.BackgroundImage = global::JobVietApp.Properties.Resources.list_gray;
            this.pic_Activity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Activity.Location = new System.Drawing.Point(106, 478);
            this.pic_Activity.Name = "pic_Activity";
            this.pic_Activity.Size = new System.Drawing.Size(46, 46);
            this.pic_Activity.TabIndex = 14;
            this.pic_Activity.TabStop = false;
            this.pic_Activity.Click += new System.EventHandler(this.pic_Activity_Click);
            // 
            // pic_Message
            // 
            this.pic_Message.BackColor = System.Drawing.Color.Transparent;
            this.pic_Message.BackgroundImage = global::JobVietApp.Properties.Resources.bell_green;
            this.pic_Message.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Message.Location = new System.Drawing.Point(186, 478);
            this.pic_Message.Name = "pic_Message";
            this.pic_Message.Size = new System.Drawing.Size(46, 46);
            this.pic_Message.TabIndex = 12;
            this.pic_Message.TabStop = false;
            // 
            // pic_Account
            // 
            this.pic_Account.BackColor = System.Drawing.Color.Transparent;
            this.pic_Account.BackgroundImage = global::JobVietApp.Properties.Resources.account_gray;
            this.pic_Account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_Account.Location = new System.Drawing.Point(265, 478);
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
            // Message
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
            this.Controls.Add(this.lb_Message);
            this.Controls.Add(this.pic_Message);
            this.Controls.Add(this.lb_Account);
            this.Controls.Add(this.pic_Account);
            this.Controls.Add(this.circularPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Activity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Message)).EndInit();
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
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.PictureBox pic_Message;
        private System.Windows.Forms.Label lb_Account;
        private System.Windows.Forms.PictureBox pic_Account;
        private System.Windows.Forms.Label title;
    }
}