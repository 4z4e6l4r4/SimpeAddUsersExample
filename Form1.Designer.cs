namespace SimpeAddUsersExample
{
    partial class Form1
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.ManRb = new System.Windows.Forms.RadioButton();
            this.FemaleRb = new System.Windows.Forms.RadioButton();
            this.UserListLbl = new System.Windows.Forms.ListBox();
            this.AddUserLbl = new System.Windows.Forms.Label();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.HighRb = new System.Windows.Forms.RadioButton();
            this.PrimaryRb = new System.Windows.Forms.RadioButton();
            this.UniversityRb = new System.Windows.Forms.RadioButton();
            this.GenderGb = new System.Windows.Forms.GroupBox();
            this.SchoolGb = new System.Windows.Forms.GroupBox();
            this.HobbiesGb = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.GenderGb.SuspendLayout();
            this.SchoolGb.SuspendLayout();
            this.HobbiesGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(97, 53);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(44, 16);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(100, 82);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 22);
            this.NameTxt.TabIndex = 1;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.Location = new System.Drawing.Point(100, 152);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.Size = new System.Drawing.Size(100, 22);
            this.SurnameTxt.TabIndex = 3;
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Location = new System.Drawing.Point(97, 123);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(61, 16);
            this.SurnameLbl.TabIndex = 2;
            this.SurnameLbl.Text = "Surname";
            // 
            // ManRb
            // 
            this.ManRb.AutoSize = true;
            this.ManRb.Checked = true;
            this.ManRb.Location = new System.Drawing.Point(13, 34);
            this.ManRb.Name = "ManRb";
            this.ManRb.Size = new System.Drawing.Size(54, 20);
            this.ManRb.TabIndex = 4;
            this.ManRb.TabStop = true;
            this.ManRb.Text = "Man";
            this.ManRb.UseVisualStyleBackColor = true;
            // 
            // FemaleRb
            // 
            this.FemaleRb.AutoSize = true;
            this.FemaleRb.Location = new System.Drawing.Point(13, 69);
            this.FemaleRb.Name = "FemaleRb";
            this.FemaleRb.Size = new System.Drawing.Size(74, 20);
            this.FemaleRb.TabIndex = 5;
            this.FemaleRb.TabStop = true;
            this.FemaleRb.Text = "Female";
            this.FemaleRb.UseVisualStyleBackColor = true;
            // 
            // UserListLbl
            // 
            this.UserListLbl.FormattingEnabled = true;
            this.UserListLbl.ItemHeight = 16;
            this.UserListLbl.Location = new System.Drawing.Point(298, 82);
            this.UserListLbl.Name = "UserListLbl";
            this.UserListLbl.Size = new System.Drawing.Size(831, 196);
            this.UserListLbl.TabIndex = 7;
            // 
            // AddUserLbl
            // 
            this.AddUserLbl.AutoSize = true;
            this.AddUserLbl.Location = new System.Drawing.Point(295, 53);
            this.AddUserLbl.Name = "AddUserLbl";
            this.AddUserLbl.Size = new System.Drawing.Size(64, 16);
            this.AddUserLbl.TabIndex = 8;
            this.AddUserLbl.Text = "Add User";
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(100, 613);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(75, 23);
            this.AddUserBtn.TabIndex = 9;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // HighRb
            // 
            this.HighRb.AutoSize = true;
            this.HighRb.Location = new System.Drawing.Point(16, 59);
            this.HighRb.Name = "HighRb";
            this.HighRb.Size = new System.Drawing.Size(56, 20);
            this.HighRb.TabIndex = 11;
            this.HighRb.Text = "High";
            this.HighRb.UseVisualStyleBackColor = true;
            // 
            // PrimaryRb
            // 
            this.PrimaryRb.AutoSize = true;
            this.PrimaryRb.Checked = true;
            this.PrimaryRb.Location = new System.Drawing.Point(16, 31);
            this.PrimaryRb.Name = "PrimaryRb";
            this.PrimaryRb.Size = new System.Drawing.Size(74, 20);
            this.PrimaryRb.TabIndex = 10;
            this.PrimaryRb.TabStop = true;
            this.PrimaryRb.Text = "Primary";
            this.PrimaryRb.UseVisualStyleBackColor = true;
            // 
            // UniversityRb
            // 
            this.UniversityRb.AutoSize = true;
            this.UniversityRb.Location = new System.Drawing.Point(16, 88);
            this.UniversityRb.Name = "UniversityRb";
            this.UniversityRb.Size = new System.Drawing.Size(87, 20);
            this.UniversityRb.TabIndex = 13;
            this.UniversityRb.Text = "University";
            this.UniversityRb.UseVisualStyleBackColor = true;
            // 
            // GenderGb
            // 
            this.GenderGb.Controls.Add(this.FemaleRb);
            this.GenderGb.Controls.Add(this.ManRb);
            this.GenderGb.Location = new System.Drawing.Point(100, 190);
            this.GenderGb.Name = "GenderGb";
            this.GenderGb.Size = new System.Drawing.Size(113, 104);
            this.GenderGb.TabIndex = 14;
            this.GenderGb.TabStop = false;
            this.GenderGb.Text = "Gender";
            // 
            // SchoolGb
            // 
            this.SchoolGb.Controls.Add(this.UniversityRb);
            this.SchoolGb.Controls.Add(this.PrimaryRb);
            this.SchoolGb.Controls.Add(this.HighRb);
            this.SchoolGb.Location = new System.Drawing.Point(100, 314);
            this.SchoolGb.Name = "SchoolGb";
            this.SchoolGb.Size = new System.Drawing.Size(113, 129);
            this.SchoolGb.TabIndex = 15;
            this.SchoolGb.TabStop = false;
            this.SchoolGb.Text = "School";
            // 
            // HobbiesGb
            // 
            this.HobbiesGb.Controls.Add(this.checkBox5);
            this.HobbiesGb.Controls.Add(this.checkBox4);
            this.HobbiesGb.Controls.Add(this.checkBox3);
            this.HobbiesGb.Controls.Add(this.checkBox2);
            this.HobbiesGb.Controls.Add(this.checkBox1);
            this.HobbiesGb.Location = new System.Drawing.Point(100, 450);
            this.HobbiesGb.Name = "HobbiesGb";
            this.HobbiesGb.Size = new System.Drawing.Size(200, 157);
            this.HobbiesGb.TabIndex = 16;
            this.HobbiesGb.TabStop = false;
            this.HobbiesGb.Text = "Hobby";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Reading";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 48);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Walking";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 74);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Sleeping";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 100);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(72, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Coding";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(5, 126);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Drawing";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 648);
            this.Controls.Add(this.HobbiesGb);
            this.Controls.Add(this.SchoolGb);
            this.Controls.Add(this.GenderGb);
            this.Controls.Add(this.AddUserBtn);
            this.Controls.Add(this.AddUserLbl);
            this.Controls.Add(this.UserListLbl);
            this.Controls.Add(this.SurnameTxt);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.NameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GenderGb.ResumeLayout(false);
            this.GenderGb.PerformLayout();
            this.SchoolGb.ResumeLayout(false);
            this.SchoolGb.PerformLayout();
            this.HobbiesGb.ResumeLayout(false);
            this.HobbiesGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox SurnameTxt;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.RadioButton ManRb;
        private System.Windows.Forms.RadioButton FemaleRb;
        private System.Windows.Forms.ListBox UserListLbl;
        private System.Windows.Forms.Label AddUserLbl;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.RadioButton HighRb;
        private System.Windows.Forms.RadioButton PrimaryRb;
        private System.Windows.Forms.RadioButton UniversityRb;
        private System.Windows.Forms.GroupBox GenderGb;
        private System.Windows.Forms.GroupBox SchoolGb;
        private System.Windows.Forms.GroupBox HobbiesGb;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

