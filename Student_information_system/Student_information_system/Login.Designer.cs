namespace Student_information_system
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.sis = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_lognumber = new System.Windows.Forms.TextBox();
            this.tb_loginpass = new System.Windows.Forms.TextBox();
            this.beu = new System.Windows.Forms.Label();
            this.pb_sign = new System.Windows.Forms.PictureBox();
            this.pb_pass = new System.Windows.Forms.PictureBox();
            this.pb_bmm = new System.Windows.Forms.PictureBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.CheckBox();
            this.pnl_signin = new System.Windows.Forms.Panel();
            this.lbl_mail = new System.Windows.Forms.LinkLabel();
            this.pb_bmu = new System.Windows.Forms.PictureBox();
            this.pm_b = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bmm)).BeginInit();
            this.pnl_signin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bmu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm_b)).BeginInit();
            this.SuspendLayout();
            // 
            // sis
            // 
            this.sis.AutoSize = true;
            this.sis.BackColor = System.Drawing.Color.Transparent;
            this.sis.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sis.ForeColor = System.Drawing.SystemColors.Desktop;
            this.sis.Location = new System.Drawing.Point(256, 98);
            this.sis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sis.Name = "sis";
            this.sis.Size = new System.Drawing.Size(232, 23);
            this.sis.TabIndex = 0;
            this.sis.Text = "Student Information System";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_login.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(225, 150);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(67, 32);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_lognumber
            // 
            this.tb_lognumber.BackColor = System.Drawing.SystemColors.Window;
            this.tb_lognumber.Location = new System.Drawing.Point(47, 70);
            this.tb_lognumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_lognumber.Name = "tb_lognumber";
            this.tb_lognumber.Size = new System.Drawing.Size(197, 20);
            this.tb_lognumber.TabIndex = 2;
            this.tb_lognumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_lognumber_KeyPress_1);
            // 
            // tb_loginpass
            // 
            this.tb_loginpass.Location = new System.Drawing.Point(47, 106);
            this.tb_loginpass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_loginpass.Name = "tb_loginpass";
            this.tb_loginpass.PasswordChar = '•';
            this.tb_loginpass.Size = new System.Drawing.Size(197, 20);
            this.tb_loginpass.TabIndex = 3;
            // 
            // beu
            // 
            this.beu.AutoSize = true;
            this.beu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beu.ForeColor = System.Drawing.Color.RoyalBlue;
            this.beu.Location = new System.Drawing.Point(74, 21);
            this.beu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.beu.Name = "beu";
            this.beu.Size = new System.Drawing.Size(191, 19);
            this.beu.TabIndex = 4;
            this.beu.Text = "Baku Engineering University";
            // 
            // pb_sign
            // 
            this.pb_sign.Image = ((System.Drawing.Image)(resources.GetObject("pb_sign.Image")));
            this.pb_sign.Location = new System.Drawing.Point(225, 70);
            this.pb_sign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_sign.Name = "pb_sign";
            this.pb_sign.Size = new System.Drawing.Size(24, 24);
            this.pb_sign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_sign.TabIndex = 4;
            this.pb_sign.TabStop = false;
            // 
            // pb_pass
            // 
            this.pb_pass.Image = ((System.Drawing.Image)(resources.GetObject("pb_pass.Image")));
            this.pb_pass.Location = new System.Drawing.Point(225, 106);
            this.pb_pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_pass.Name = "pb_pass";
            this.pb_pass.Size = new System.Drawing.Size(18, 18);
            this.pb_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pass.TabIndex = 5;
            this.pb_pass.TabStop = false;
            // 
            // pb_bmm
            // 
            this.pb_bmm.Image = global::Student_information_system.Properties.Resources.logo_150;
            this.pb_bmm.Location = new System.Drawing.Point(25, 12);
            this.pb_bmm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_bmm.Name = "pb_bmm";
            this.pb_bmm.Size = new System.Drawing.Size(45, 41);
            this.pb_bmm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bmm.TabIndex = 6;
            this.pb_bmm.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_status.Location = new System.Drawing.Point(10, 128);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 13);
            this.lbl_status.TabIndex = 8;
            // 
            // cb
            // 
            this.cb.AutoSize = true;
            this.cb.BackColor = System.Drawing.Color.Transparent;
            this.cb.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cb.Location = new System.Drawing.Point(13, 159);
            this.cb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(107, 17);
            this.cb.TabIndex = 9;
            this.cb.Text = "Show Password";
            this.cb.UseVisualStyleBackColor = false;
            this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged_1);
            // 
            // pnl_signin
            // 
            this.pnl_signin.BackColor = System.Drawing.Color.White;
            this.pnl_signin.Controls.Add(this.cb);
            this.pnl_signin.Controls.Add(this.lbl_status);
            this.pnl_signin.Controls.Add(this.pb_bmm);
            this.pnl_signin.Controls.Add(this.pb_pass);
            this.pnl_signin.Controls.Add(this.pb_sign);
            this.pnl_signin.Controls.Add(this.beu);
            this.pnl_signin.Controls.Add(this.tb_loginpass);
            this.pnl_signin.Controls.Add(this.tb_lognumber);
            this.pnl_signin.Controls.Add(this.btn_login);
            this.pnl_signin.Location = new System.Drawing.Point(201, 132);
            this.pnl_signin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_signin.Name = "pnl_signin";
            this.pnl_signin.Size = new System.Drawing.Size(315, 193);
            this.pnl_signin.TabIndex = 2;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mail.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_mail.LinkColor = System.Drawing.Color.Blue;
            this.lbl_mail.Location = new System.Drawing.Point(422, 327);
            this.lbl_mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(92, 13);
            this.lbl_mail.TabIndex = 3;
            this.lbl_mail.TabStop = true;
            this.lbl_mail.Text = "Login to BEU Mail";
            this.lbl_mail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_mail_LinkClicked);
            // 
            // pb_bmu
            // 
            this.pb_bmu.BackColor = System.Drawing.Color.Transparent;
            this.pb_bmu.Image = global::Student_information_system.Properties.Resources._1200px_BMU_logo_svg;
            this.pb_bmu.Location = new System.Drawing.Point(9, 10);
            this.pb_bmu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_bmu.Name = "pb_bmu";
            this.pb_bmu.Size = new System.Drawing.Size(232, 74);
            this.pb_bmu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_bmu.TabIndex = 4;
            this.pb_bmu.TabStop = false;
            // 
            // pm_b
            // 
            this.pm_b.Image = ((System.Drawing.Image)(resources.GetObject("pm_b.Image")));
            this.pm_b.Location = new System.Drawing.Point(406, 330);
            this.pm_b.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pm_b.Name = "pm_b";
            this.pm_b.Size = new System.Drawing.Size(12, 9);
            this.pm_b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pm_b.TabIndex = 6;
            this.pm_b.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_information_system.Properties.Resources.wp_edu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(772, 500);
            this.Controls.Add(this.pm_b);
            this.Controls.Add(this.pb_bmu);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.pnl_signin);
            this.Controls.Add(this.sis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_sign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bmm)).EndInit();
            this.pnl_signin.ResumeLayout(false);
            this.pnl_signin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_bmu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pm_b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sis;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_lognumber;
        private System.Windows.Forms.TextBox tb_loginpass;
        private System.Windows.Forms.Label beu;
        private System.Windows.Forms.PictureBox pb_sign;
        private System.Windows.Forms.PictureBox pb_pass;
        private System.Windows.Forms.PictureBox pb_bmm;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.CheckBox cb;
        private System.Windows.Forms.Panel pnl_signin;
        private System.Windows.Forms.LinkLabel lbl_mail;
        private System.Windows.Forms.PictureBox pb_bmu;
        private System.Windows.Forms.PictureBox pm_b;
    }
}

