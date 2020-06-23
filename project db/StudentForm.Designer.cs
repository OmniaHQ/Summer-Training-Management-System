namespace project_db
{
    partial class StudentForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.projectsBtn = new System.Windows.Forms.Button();
            this.coursesBtn = new System.Windows.Forms.Button();
            this.searchBtn1 = new System.Windows.Forms.Button();
            this.nameLblStud = new System.Windows.Forms.Label();
            this.idLblStud = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchPage = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enBtn = new System.Windows.Forms.Button();
            this.backBtn1 = new System.Windows.Forms.Button();
            this.searchBtn2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enrolledPage = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gradesBtn = new System.Windows.Forms.Button();
            this.backBtn2 = new System.Windows.Forms.Button();
            this.disenBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectPage = new System.Windows.Forms.TabPage();
            this.backBtn4 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.joinBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.enrolledPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.projectPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.searchPage);
            this.tabControl1.Controls.Add(this.enrolledPage);
            this.tabControl1.Controls.Add(this.projectPage);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(451, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.logOutBtn);
            this.mainPage.Controls.Add(this.projectsBtn);
            this.mainPage.Controls.Add(this.coursesBtn);
            this.mainPage.Controls.Add(this.searchBtn1);
            this.mainPage.Controls.Add(this.nameLblStud);
            this.mainPage.Controls.Add(this.idLblStud);
            this.mainPage.Controls.Add(this.label2);
            this.mainPage.Controls.Add(this.label1);
            this.mainPage.Location = new System.Drawing.Point(4, 25);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(443, 430);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Main Page";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Location = new System.Drawing.Point(41, 311);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(75, 23);
            this.logOutBtn.TabIndex = 10;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // projectsBtn
            // 
            this.projectsBtn.Location = new System.Drawing.Point(102, 224);
            this.projectsBtn.Name = "projectsBtn";
            this.projectsBtn.Size = new System.Drawing.Size(75, 23);
            this.projectsBtn.TabIndex = 9;
            this.projectsBtn.Text = "Projects";
            this.projectsBtn.UseVisualStyleBackColor = true;
            this.projectsBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // coursesBtn
            // 
            this.coursesBtn.Location = new System.Drawing.Point(164, 168);
            this.coursesBtn.Name = "coursesBtn";
            this.coursesBtn.Size = new System.Drawing.Size(75, 23);
            this.coursesBtn.TabIndex = 6;
            this.coursesBtn.Text = "Courses";
            this.coursesBtn.UseVisualStyleBackColor = true;
            this.coursesBtn.Click += new System.EventHandler(this.coursesBtn_Click);
            // 
            // searchBtn1
            // 
            this.searchBtn1.Location = new System.Drawing.Point(41, 168);
            this.searchBtn1.Name = "searchBtn1";
            this.searchBtn1.Size = new System.Drawing.Size(75, 23);
            this.searchBtn1.TabIndex = 5;
            this.searchBtn1.Text = "Search Courses";
            this.searchBtn1.UseVisualStyleBackColor = true;
            this.searchBtn1.Click += new System.EventHandler(this.searchBtn1_Click);
            // 
            // nameLblStud
            // 
            this.nameLblStud.AutoSize = true;
            this.nameLblStud.Location = new System.Drawing.Point(161, 86);
            this.nameLblStud.Name = "nameLblStud";
            this.nameLblStud.Size = new System.Drawing.Size(46, 17);
            this.nameLblStud.TabIndex = 4;
            this.nameLblStud.Text = "label5";
            this.nameLblStud.Click += new System.EventHandler(this.label5_Click);
            // 
            // idLblStud
            // 
            this.idLblStud.AutoSize = true;
            this.idLblStud.Location = new System.Drawing.Point(161, 36);
            this.idLblStud.Name = "idLblStud";
            this.idLblStud.Size = new System.Drawing.Size(46, 17);
            this.idLblStud.TabIndex = 3;
            this.idLblStud.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.textBox4);
            this.searchPage.Controls.Add(this.label4);
            this.searchPage.Controls.Add(this.enBtn);
            this.searchPage.Controls.Add(this.backBtn1);
            this.searchPage.Controls.Add(this.searchBtn2);
            this.searchPage.Controls.Add(this.textBox1);
            this.searchPage.Controls.Add(this.dataGridView1);
            this.searchPage.Location = new System.Drawing.Point(4, 25);
            this.searchPage.Name = "searchPage";
            this.searchPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchPage.Size = new System.Drawing.Size(443, 430);
            this.searchPage.TabIndex = 1;
            this.searchPage.Text = "Search";
            this.searchPage.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(200, 312);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter course ID:";
            // 
            // enBtn
            // 
            this.enBtn.Location = new System.Drawing.Point(279, 355);
            this.enBtn.Name = "enBtn";
            this.enBtn.Size = new System.Drawing.Size(75, 23);
            this.enBtn.TabIndex = 4;
            this.enBtn.Text = "Enroll";
            this.enBtn.UseVisualStyleBackColor = true;
            this.enBtn.Click += new System.EventHandler(this.enBtn_Click);
            // 
            // backBtn1
            // 
            this.backBtn1.Location = new System.Drawing.Point(32, 397);
            this.backBtn1.Name = "backBtn1";
            this.backBtn1.Size = new System.Drawing.Size(75, 23);
            this.backBtn1.TabIndex = 3;
            this.backBtn1.Text = "Back";
            this.backBtn1.UseVisualStyleBackColor = true;
            this.backBtn1.Click += new System.EventHandler(this.backBtn1_Click);
            // 
            // searchBtn2
            // 
            this.searchBtn2.Location = new System.Drawing.Point(279, 24);
            this.searchBtn2.Name = "searchBtn2";
            this.searchBtn2.Size = new System.Drawing.Size(75, 23);
            this.searchBtn2.TabIndex = 2;
            this.searchBtn2.Text = "Search";
            this.searchBtn2.UseVisualStyleBackColor = true;
            this.searchBtn2.Click += new System.EventHandler(this.searchBtn2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(32, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(376, 216);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "description";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Course ID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lecturer ID";
            this.Column4.Name = "Column4";
            // 
            // enrolledPage
            // 
            this.enrolledPage.Controls.Add(this.textBox3);
            this.enrolledPage.Controls.Add(this.label3);
            this.enrolledPage.Controls.Add(this.textBox2);
            this.enrolledPage.Controls.Add(this.gradesBtn);
            this.enrolledPage.Controls.Add(this.backBtn2);
            this.enrolledPage.Controls.Add(this.disenBtn);
            this.enrolledPage.Controls.Add(this.dataGridView2);
            this.enrolledPage.Location = new System.Drawing.Point(4, 25);
            this.enrolledPage.Name = "enrolledPage";
            this.enrolledPage.Size = new System.Drawing.Size(443, 430);
            this.enrolledPage.TabIndex = 2;
            this.enrolledPage.Text = "Enrolled";
            this.enrolledPage.UseVisualStyleBackColor = true;
            this.enrolledPage.Click += new System.EventHandler(this.enrolledPage_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(220, 240);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter course ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // gradesBtn
            // 
            this.gradesBtn.Location = new System.Drawing.Point(76, 283);
            this.gradesBtn.Name = "gradesBtn";
            this.gradesBtn.Size = new System.Drawing.Size(103, 22);
            this.gradesBtn.TabIndex = 7;
            this.gradesBtn.Text = "check grade";
            this.gradesBtn.UseVisualStyleBackColor = true;
            this.gradesBtn.Click += new System.EventHandler(this.gradesBtn_Click);
            // 
            // backBtn2
            // 
            this.backBtn2.Location = new System.Drawing.Point(24, 397);
            this.backBtn2.Name = "backBtn2";
            this.backBtn2.Size = new System.Drawing.Size(75, 23);
            this.backBtn2.TabIndex = 6;
            this.backBtn2.Text = "Back";
            this.backBtn2.UseVisualStyleBackColor = true;
            this.backBtn2.Click += new System.EventHandler(this.backBtn2_Click);
            // 
            // disenBtn
            // 
            this.disenBtn.Location = new System.Drawing.Point(288, 349);
            this.disenBtn.Name = "disenBtn";
            this.disenBtn.Size = new System.Drawing.Size(103, 35);
            this.disenBtn.TabIndex = 5;
            this.disenBtn.Text = "Disenroll";
            this.disenBtn.UseVisualStyleBackColor = true;
            this.disenBtn.Click += new System.EventHandler(this.disenBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView2.Location = new System.Drawing.Point(0, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(440, 216);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Name";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Description";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Course ID";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Lecturer ID";
            this.Column8.Name = "Column8";
            // 
            // projectPage
            // 
            this.projectPage.Controls.Add(this.messageLbl);
            this.projectPage.Controls.Add(this.label9);
            this.projectPage.Controls.Add(this.label8);
            this.projectPage.Controls.Add(this.label6);
            this.projectPage.Controls.Add(this.label5);
            this.projectPage.Controls.Add(this.textBox7);
            this.projectPage.Controls.Add(this.textBox5);
            this.projectPage.Controls.Add(this.dataGridView4);
            this.projectPage.Controls.Add(this.createBtn);
            this.projectPage.Controls.Add(this.joinBtn);
            this.projectPage.Controls.Add(this.dataGridView3);
            this.projectPage.Controls.Add(this.backBtn4);
            this.projectPage.Location = new System.Drawing.Point(4, 25);
            this.projectPage.Name = "projectPage";
            this.projectPage.Size = new System.Drawing.Size(443, 430);
            this.projectPage.TabIndex = 5;
            this.projectPage.Text = "Projects";
            this.projectPage.UseVisualStyleBackColor = true;
            // 
            // backBtn4
            // 
            this.backBtn4.Location = new System.Drawing.Point(9, 367);
            this.backBtn4.Name = "backBtn4";
            this.backBtn4.Size = new System.Drawing.Size(75, 23);
            this.backBtn4.TabIndex = 7;
            this.backBtn4.Text = "Back";
            this.backBtn4.UseVisualStyleBackColor = true;
            this.backBtn4.Click += new System.EventHandler(this.backBtn4_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column14,
            this.Column13});
            this.dataGridView3.Location = new System.Drawing.Point(4, 42);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(215, 221);
            this.dataGridView3.TabIndex = 8;
            // 
            // joinBtn
            // 
            this.joinBtn.Location = new System.Drawing.Point(295, 355);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(97, 27);
            this.joinBtn.TabIndex = 9;
            this.joinBtn.Text = "Join team";
            this.joinBtn.UseVisualStyleBackColor = true;
            this.joinBtn.Click += new System.EventHandler(this.joinBtn_Click);
            this.joinBtn.MouseLeave += new System.EventHandler(this.joinBtn_MouseLeave);
            this.joinBtn.MouseHover += new System.EventHandler(this.joinBtn_MouseHover);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(141, 355);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(105, 27);
            this.createBtn.TabIndex = 10;
            this.createBtn.Text = "Create Team";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            this.createBtn.MouseLeave += new System.EventHandler(this.createBtn_MouseLeave);
            this.createBtn.MouseHover += new System.EventHandler(this.createBtn_MouseHover);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView4.Location = new System.Drawing.Point(225, 42);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(215, 221);
            this.dataGridView4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(240, 295);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(55, 22);
            this.textBox5.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(102, 295);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(56, 22);
            this.textBox7.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Team ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Project ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Projects";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Your Teams";
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Location = new System.Drawing.Point(146, 335);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(12, 17);
            this.messageLbl.TabIndex = 20;
            this.messageLbl.Text = ".";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Student ID";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Project Num ";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Team ID";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Project Num";
            this.Column12.Name = "Column12";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Name";
            this.Column14.Name = "Column14";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Description";
            this.Column13.Name = "Column13";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 457);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.tabControl1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.searchPage.ResumeLayout(false);
            this.searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.enrolledPage.ResumeLayout(false);
            this.enrolledPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.projectPage.ResumeLayout(false);
            this.projectPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage searchPage;
        private System.Windows.Forms.TabPage enrolledPage;
        private System.Windows.Forms.TabPage projectPage;
        private System.Windows.Forms.Label nameLblStud;
        private System.Windows.Forms.Label idLblStud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button projectsBtn;
        private System.Windows.Forms.Button coursesBtn;
        private System.Windows.Forms.Button searchBtn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBtn2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button backBtn1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button enBtn;
        private System.Windows.Forms.Button disenBtn;
        private System.Windows.Forms.Button backBtn2;
        private System.Windows.Forms.Button backBtn4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button gradesBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}