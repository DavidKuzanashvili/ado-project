namespace HR
{
    partial class HRForm
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
            this.PositionDropDownList = new System.Windows.Forms.ComboBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Surename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.MobileNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SaveEmployeeBtn = new System.Windows.Forms.Button();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.ChangePositionTitle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ChnagePositionComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ChangePositionPN = new System.Windows.Forms.TextBox();
            this.changePositionBtn = new System.Windows.Forms.Button();
            this.examTitle = new System.Windows.Forms.Label();
            this.examNameInput = new System.Windows.Forms.TextBox();
            this.examDescription = new System.Windows.Forms.TextBox();
            this.maxScore = new System.Windows.Forms.TextBox();
            this.examName = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.maxScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionDropDownList
            // 
            this.PositionDropDownList.FormattingEnabled = true;
            this.PositionDropDownList.Items.AddRange(new object[] {
            "Director",
            "Secretary",
            "ChiefOfDepartment",
            "MainSpecialist",
            "Specialist"});
            this.PositionDropDownList.Location = new System.Drawing.Point(42, 106);
            this.PositionDropDownList.Name = "PositionDropDownList";
            this.PositionDropDownList.Size = new System.Drawing.Size(175, 21);
            this.PositionDropDownList.TabIndex = 1;
            // 
            // EmpName
            // 
            this.EmpName.BackColor = System.Drawing.Color.White;
            this.EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpName.ForeColor = System.Drawing.Color.Black;
            this.EmpName.Location = new System.Drawing.Point(42, 170);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(175, 20);
            this.EmpName.TabIndex = 2;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Title.Location = new System.Drawing.Point(38, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(136, 24);
            this.Title.TabIndex = 4;
            this.Title.Text = "Add Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // Surename
            // 
            this.Surename.BackColor = System.Drawing.Color.White;
            this.Surename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surename.ForeColor = System.Drawing.Color.Black;
            this.Surename.Location = new System.Drawing.Point(42, 233);
            this.Surename.Name = "Surename";
            this.Surename.Size = new System.Drawing.Size(175, 20);
            this.Surename.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Surename";
            // 
            // PN
            // 
            this.PN.BackColor = System.Drawing.Color.White;
            this.PN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PN.ForeColor = System.Drawing.Color.Black;
            this.PN.Location = new System.Drawing.Point(42, 292);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(175, 20);
            this.PN.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "P / N";
            // 
            // BirthDay
            // 
            this.BirthDay.CustomFormat = "YYYY-MM-DD";
            this.BirthDay.Location = new System.Drawing.Point(42, 355);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(200, 20);
            this.BirthDay.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Birth Day";
            // 
            // MobileNumber
            // 
            this.MobileNumber.BackColor = System.Drawing.Color.White;
            this.MobileNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNumber.ForeColor = System.Drawing.Color.Black;
            this.MobileNumber.Location = new System.Drawing.Point(42, 417);
            this.MobileNumber.Name = "MobileNumber";
            this.MobileNumber.Size = new System.Drawing.Size(175, 20);
            this.MobileNumber.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mobile Number";
            // 
            // Mail
            // 
            this.Mail.BackColor = System.Drawing.Color.White;
            this.Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.ForeColor = System.Drawing.Color.Black;
            this.Mail.Location = new System.Drawing.Point(42, 480);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(175, 20);
            this.Mail.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Email";
            // 
            // SaveEmployeeBtn
            // 
            this.SaveEmployeeBtn.Location = new System.Drawing.Point(80, 515);
            this.SaveEmployeeBtn.Name = "SaveEmployeeBtn";
            this.SaveEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveEmployeeBtn.TabIndex = 17;
            this.SaveEmployeeBtn.Text = "Save";
            this.SaveEmployeeBtn.UseVisualStyleBackColor = true;
            this.SaveEmployeeBtn.Click += new System.EventHandler(this.SaveEmployeeBtn_Click);
            // 
            // employeeGridView
            // 
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Location = new System.Drawing.Point(295, 45);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.Size = new System.Drawing.Size(511, 493);
            this.employeeGridView.TabIndex = 18;
            // 
            // ChangePositionTitle
            // 
            this.ChangePositionTitle.AutoSize = true;
            this.ChangePositionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePositionTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ChangePositionTitle.Location = new System.Drawing.Point(891, 45);
            this.ChangePositionTitle.Name = "ChangePositionTitle";
            this.ChangePositionTitle.Size = new System.Drawing.Size(252, 24);
            this.ChangePositionTitle.TabIndex = 19;
            this.ChangePositionTitle.Text = "Change Employee\'s Position";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(892, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Select Position";
            // 
            // ChnagePositionComboBox
            // 
            this.ChnagePositionComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Director",
            "Secretary",
            "ChiefOfDepartment",
            "MainSpecialist",
            "Specialist"});
            this.ChnagePositionComboBox.FormattingEnabled = true;
            this.ChnagePositionComboBox.Items.AddRange(new object[] {
            "Director",
            "Secretary",
            "ChiefOfDepartment",
            "MainSpecialist",
            "Specialist"});
            this.ChnagePositionComboBox.Location = new System.Drawing.Point(895, 106);
            this.ChnagePositionComboBox.Name = "ChnagePositionComboBox";
            this.ChnagePositionComboBox.Size = new System.Drawing.Size(175, 21);
            this.ChnagePositionComboBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(892, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "P / N";
            // 
            // ChangePositionPN
            // 
            this.ChangePositionPN.BackColor = System.Drawing.Color.White;
            this.ChangePositionPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePositionPN.ForeColor = System.Drawing.Color.Black;
            this.ChangePositionPN.Location = new System.Drawing.Point(895, 170);
            this.ChangePositionPN.Name = "ChangePositionPN";
            this.ChangePositionPN.Size = new System.Drawing.Size(175, 20);
            this.ChangePositionPN.TabIndex = 23;
            // 
            // changePositionBtn
            // 
            this.changePositionBtn.Location = new System.Drawing.Point(935, 218);
            this.changePositionBtn.Name = "changePositionBtn";
            this.changePositionBtn.Size = new System.Drawing.Size(75, 23);
            this.changePositionBtn.TabIndex = 24;
            this.changePositionBtn.Text = "Change";
            this.changePositionBtn.UseVisualStyleBackColor = true;
            this.changePositionBtn.Click += new System.EventHandler(this.changePositionBtn_Click);
            // 
            // examTitle
            // 
            this.examTitle.AutoSize = true;
            this.examTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.examTitle.Location = new System.Drawing.Point(891, 292);
            this.examTitle.Name = "examTitle";
            this.examTitle.Size = new System.Drawing.Size(99, 24);
            this.examTitle.TabIndex = 25;
            this.examTitle.Text = "Add Exam";
            // 
            // examNameInput
            // 
            this.examNameInput.BackColor = System.Drawing.Color.White;
            this.examNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examNameInput.ForeColor = System.Drawing.Color.Black;
            this.examNameInput.Location = new System.Drawing.Point(895, 355);
            this.examNameInput.Name = "examNameInput";
            this.examNameInput.Size = new System.Drawing.Size(175, 20);
            this.examNameInput.TabIndex = 26;
            // 
            // examDescription
            // 
            this.examDescription.BackColor = System.Drawing.Color.White;
            this.examDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examDescription.ForeColor = System.Drawing.Color.Black;
            this.examDescription.Location = new System.Drawing.Point(895, 417);
            this.examDescription.Name = "examDescription";
            this.examDescription.Size = new System.Drawing.Size(175, 20);
            this.examDescription.TabIndex = 27;
            // 
            // maxScore
            // 
            this.maxScore.BackColor = System.Drawing.Color.White;
            this.maxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxScore.ForeColor = System.Drawing.Color.Black;
            this.maxScore.Location = new System.Drawing.Point(895, 480);
            this.maxScore.Name = "maxScore";
            this.maxScore.Size = new System.Drawing.Size(175, 20);
            this.maxScore.TabIndex = 28;
            // 
            // examName
            // 
            this.examName.AutoSize = true;
            this.examName.Location = new System.Drawing.Point(893, 324);
            this.examName.Name = "examName";
            this.examName.Size = new System.Drawing.Size(35, 13);
            this.examName.TabIndex = 29;
            this.examName.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(893, 392);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 30;
            this.descriptionLabel.Text = "Description";
            // 
            // maxScoreLabel
            // 
            this.maxScoreLabel.AutoSize = true;
            this.maxScoreLabel.Location = new System.Drawing.Point(892, 451);
            this.maxScoreLabel.Name = "maxScoreLabel";
            this.maxScoreLabel.Size = new System.Drawing.Size(58, 13);
            this.maxScoreLabel.TabIndex = 31;
            this.maxScoreLabel.Text = "Max Score";
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1210, 808);
            this.Controls.Add(this.maxScoreLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.examName);
            this.Controls.Add(this.maxScore);
            this.Controls.Add(this.examDescription);
            this.Controls.Add(this.examNameInput);
            this.Controls.Add(this.examTitle);
            this.Controls.Add(this.changePositionBtn);
            this.Controls.Add(this.ChangePositionPN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ChnagePositionComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChangePositionTitle);
            this.Controls.Add(this.employeeGridView);
            this.Controls.Add(this.SaveEmployeeBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MobileNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Surename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.PositionDropDownList);
            this.Name = "HRForm";
            this.Text = "HRForm";
            this.Load += new System.EventHandler(this.HRForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PositionDropDownList;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Surename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker BirthDay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MobileNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SaveEmployeeBtn;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.Label ChangePositionTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ChnagePositionComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ChangePositionPN;
        private System.Windows.Forms.Button changePositionBtn;
        private System.Windows.Forms.Label examTitle;
        private System.Windows.Forms.TextBox examNameInput;
        private System.Windows.Forms.TextBox examDescription;
        private System.Windows.Forms.TextBox maxScore;
        private System.Windows.Forms.Label examName;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label maxScoreLabel;
    }
}