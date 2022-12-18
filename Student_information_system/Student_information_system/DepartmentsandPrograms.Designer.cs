namespace Student_information_system
{
    partial class DepartmentsandPrograms
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
            this.lbl_li = new System.Windows.Forms.Label();
            this.lbl_div = new System.Windows.Forms.Label();
            this.departments_dgw = new System.Windows.Forms.DataGridView();
            this.pnl_dpr = new System.Windows.Forms.Panel();
            this.pnll = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_tms = new System.Windows.Forms.LinkLabel();
            this.menubutton = new System.Windows.Forms.PictureBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_depp = new System.Windows.Forms.Button();
            this.btn_structure = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.departments_dgw)).BeginInit();
            this.pnl_dpr.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_li
            // 
            this.lbl_li.AutoSize = true;
            this.lbl_li.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_li.Location = new System.Drawing.Point(64, 34);
            this.lbl_li.Name = "lbl_li";
            this.lbl_li.Size = new System.Drawing.Size(340, 50);
            this.lbl_li.TabIndex = 0;
            this.lbl_li.Text = "List of departments";
            // 
            // lbl_div
            // 
            this.lbl_div.AutoSize = true;
            this.lbl_div.Location = new System.Drawing.Point(104, 102);
            this.lbl_div.Name = "lbl_div";
            this.lbl_div.Size = new System.Drawing.Size(624, 46);
            this.lbl_div.TabIndex = 1;
            this.lbl_div.Text = "Here you can see the departments included in the system, study code prefixes of\r\n" +
    " the departments and the programs of the departments by year.";
            // 
            // departments_dgw
            // 
            this.departments_dgw.AllowUserToAddRows = false;
            this.departments_dgw.AllowUserToDeleteRows = false;
            this.departments_dgw.AllowUserToOrderColumns = true;
            this.departments_dgw.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.departments_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departments_dgw.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.departments_dgw.Location = new System.Drawing.Point(0, 156);
            this.departments_dgw.Name = "departments_dgw";
            this.departments_dgw.ReadOnly = true;
            this.departments_dgw.RowHeadersWidth = 70;
            this.departments_dgw.RowTemplate.Height = 24;
            this.departments_dgw.Size = new System.Drawing.Size(771, 657);
            this.departments_dgw.TabIndex = 2;
            // 
            // pnl_dpr
            // 
            this.pnl_dpr.Controls.Add(this.departments_dgw);
            this.pnl_dpr.Controls.Add(this.lbl_div);
            this.pnl_dpr.Controls.Add(this.lbl_li);
            this.pnl_dpr.Location = new System.Drawing.Point(352, 66);
            this.pnl_dpr.Name = "pnl_dpr";
            this.pnl_dpr.Size = new System.Drawing.Size(771, 831);
            this.pnl_dpr.TabIndex = 10;
            // 
            // pnll
            // 
            this.pnll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnll.Location = new System.Drawing.Point(345, 8);
            this.pnll.Name = "pnll";
            this.pnll.Size = new System.Drawing.Size(814, 57);
            this.pnll.TabIndex = 12;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.btn_home);
            this.sidebar.Controls.Add(this.button4);
            this.sidebar.Controls.Add(this.btn_depp);
            this.sidebar.Controls.Add(this.btn_structure);
            this.sidebar.Controls.Add(this.button3);
            this.sidebar.Controls.Add(this.button6);
            this.sidebar.Controls.Add(this.button1);
            this.sidebar.Controls.Add(this.button2);
            this.sidebar.Controls.Add(this.button7);
            this.sidebar.Controls.Add(this.button8);
            this.sidebar.Controls.Add(this.button9);
            this.sidebar.Controls.Add(this.button10);
            this.sidebar.Controls.Add(this.button11);
            this.sidebar.Controls.Add(this.button12);
            this.sidebar.Controls.Add(this.button13);
            this.sidebar.Controls.Add(this.button14);
            this.sidebar.ForeColor = System.Drawing.Color.Transparent;
            this.sidebar.Location = new System.Drawing.Point(4, 8);
            this.sidebar.MaximumSize = new System.Drawing.Size(342, 900);
            this.sidebar.MinimumSize = new System.Drawing.Size(84, 900);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(342, 900);
            this.sidebar.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.lbl_tms);
            this.panel2.Controls.Add(this.menubutton);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 100);
            this.panel2.TabIndex = 0;
            // 
            // lbl_tms
            // 
            this.lbl_tms.AutoSize = true;
            this.lbl_tms.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tms.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tms.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbl_tms.LinkColor = System.Drawing.Color.White;
            this.lbl_tms.Location = new System.Drawing.Point(60, 29);
            this.lbl_tms.Name = "lbl_tms";
            this.lbl_tms.Size = new System.Drawing.Size(272, 25);
            this.lbl_tms.TabIndex = 8;
            this.lbl_tms.TabStop = true;
            this.lbl_tms.Text = "    Student Information System";
            this.lbl_tms.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menubutton
            // 
            this.menubutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubutton.Image = global::Student_information_system.Properties.Resources.icons8_menu_50;
            this.menubutton.Location = new System.Drawing.Point(9, 29);
            this.menubutton.Name = "menubutton";
            this.menubutton.Size = new System.Drawing.Size(45, 40);
            this.menubutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menubutton.TabIndex = 6;
            this.menubutton.TabStop = false;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = global::Student_information_system.Properties.Resources.icons8_home_page_30;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(3, 109);
            this.btn_home.Name = "btn_home";
            this.btn_home.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_home.Size = new System.Drawing.Size(335, 43);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "             Home Page";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Student_information_system.Properties.Resources.icons8_announce_32__1_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 158);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(335, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "             Announces";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_depp
            // 
            this.btn_depp.BackColor = System.Drawing.Color.Gray;
            this.btn_depp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_depp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_depp.ForeColor = System.Drawing.Color.White;
            this.btn_depp.Image = global::Student_information_system.Properties.Resources.icons8_start_menu_32;
            this.btn_depp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_depp.Location = new System.Drawing.Point(3, 207);
            this.btn_depp.Name = "btn_depp";
            this.btn_depp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_depp.Size = new System.Drawing.Size(335, 43);
            this.btn_depp.TabIndex = 6;
            this.btn_depp.Text = "             Departments and Programs";
            this.btn_depp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_depp.UseVisualStyleBackColor = false;
            this.btn_depp.Click += new System.EventHandler(this.btn_depp_Click);
            // 
            // btn_structure
            // 
            this.btn_structure.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_structure.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_structure.ForeColor = System.Drawing.Color.White;
            this.btn_structure.Image = global::Student_information_system.Properties.Resources.icons8_paper_30;
            this.btn_structure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_structure.Location = new System.Drawing.Point(3, 256);
            this.btn_structure.Name = "btn_structure";
            this.btn_structure.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_structure.Size = new System.Drawing.Size(335, 43);
            this.btn_structure.TabIndex = 25;
            this.btn_structure.Text = "             Course Structure";
            this.btn_structure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_structure.UseVisualStyleBackColor = true;
            this.btn_structure.Click += new System.EventHandler(this.btn_structure_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Student_information_system.Properties.Resources.icons8_classroom_30;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 305);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(335, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "             Course Registration";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Student_information_system.Properties.Resources.icons8_timetable_30;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 354);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(335, 43);
            this.button6.TabIndex = 8;
            this.button6.Text = "             Course schedule";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Student_information_system.Properties.Resources.icons8_grades_30;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 403);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(335, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "             Grades List";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Student_information_system.Properties.Resources.icons8_courthouse_30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 452);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(335, 43);
            this.button2.TabIndex = 26;
            this.button2.Text = "             Transkript";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::Student_information_system.Properties.Resources.icons8_attendance_32;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 501);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(335, 43);
            this.button7.TabIndex = 27;
            this.button7.Text = "              Electronic Attendance";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::Student_information_system.Properties.Resources.icons8_front_gate_open_30;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 550);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(335, 43);
            this.button8.TabIndex = 28;
            this.button8.Text = "             Gate Entry Records";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::Student_information_system.Properties.Resources.icons8_book_shelf_30;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(3, 599);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(335, 43);
            this.button9.TabIndex = 29;
            this.button9.Text = "             Library";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Image = global::Student_information_system.Properties.Resources.icons8_cursor_in_window_30;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(3, 648);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(335, 43);
            this.button10.TabIndex = 30;
            this.button10.Text = "             Online Services";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = global::Student_information_system.Properties.Resources.icons8_question_mark_30;
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(3, 697);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button11.Size = new System.Drawing.Size(335, 43);
            this.button11.TabIndex = 31;
            this.button11.Text = "             Questionnaire";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Image = global::Student_information_system.Properties.Resources.icons8_services_30;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(3, 746);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button12.Size = new System.Drawing.Size(335, 43);
            this.button12.TabIndex = 32;
            this.button12.Text = "              Setting";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = global::Student_information_system.Properties.Resources.icons8_contact_30;
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(3, 795);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button13.Size = new System.Drawing.Size(335, 43);
            this.button13.TabIndex = 33;
            this.button13.Text = "             Contact";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Image = global::Student_information_system.Properties.Resources.icons8_exam_30;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 844);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button14.Size = new System.Drawing.Size(335, 43);
            this.button14.TabIndex = 34;
            this.button14.Text = "             Apply for re-examination";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // DepartmentsandPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1170, 814);
            this.Controls.Add(this.pnll);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnl_dpr);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1170, 814);
            this.MinimumSize = new System.Drawing.Size(1154, 814);
            this.Name = "DepartmentsandPrograms";
            this.Text = "DepartmentsandPrograms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DepartmentsandPrograms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departments_dgw)).EndInit();
            this.pnl_dpr.ResumeLayout(false);
            this.pnl_dpr.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menubutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_li;
        private System.Windows.Forms.Label lbl_div;
        public System.Windows.Forms.DataGridView departments_dgw;
        private System.Windows.Forms.Panel pnl_dpr;
        private System.Windows.Forms.Panel pnll;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lbl_tms;
        private System.Windows.Forms.PictureBox menubutton;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_depp;
        private System.Windows.Forms.Button btn_structure;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}