namespace DotNetPractical.WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            student_name = new Label();
            textName = new TextBox();
            student_age = new Label();
            textAge = new TextBox();
            textYear = new TextBox();
            student_year = new Label();
            textJoinDate = new TextBox();
            join_date = new Label();
            major = new Label();
            textMajor = new TextBox();
            label1 = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // student_name
            // 
            student_name.AutoSize = true;
            student_name.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_name.Location = new Point(43, 138);
            student_name.Name = "student_name";
            student_name.Size = new Size(138, 26);
            student_name.TabIndex = 0;
            student_name.Text = "Student Name";
            // 
            // textName
            // 
            textName.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textName.Location = new Point(180, 134);
            textName.Name = "textName";
            textName.Size = new Size(201, 34);
            textName.TabIndex = 3;
            // 
            // student_age
            // 
            student_age.AutoSize = true;
            student_age.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_age.Location = new Point(491, 142);
            student_age.Name = "student_age";
            student_age.Size = new Size(45, 26);
            student_age.TabIndex = 4;
            student_age.Text = "Age";
            // 
            // textAge
            // 
            textAge.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textAge.Location = new Point(539, 134);
            textAge.Name = "textAge";
            textAge.Size = new Size(201, 34);
            textAge.TabIndex = 5;
            // 
            // textYear
            // 
            textYear.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textYear.Location = new Point(180, 204);
            textYear.Name = "textYear";
            textYear.Size = new Size(201, 34);
            textYear.TabIndex = 6;
            // 
            // student_year
            // 
            student_year.AutoSize = true;
            student_year.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            student_year.Location = new Point(43, 204);
            student_year.Name = "student_year";
            student_year.Size = new Size(129, 26);
            student_year.TabIndex = 7;
            student_year.Text = "Student Year";
            // 
            // textJoinDate
            // 
            textJoinDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textJoinDate.Location = new Point(539, 214);
            textJoinDate.Name = "textJoinDate";
            textJoinDate.Size = new Size(201, 34);
            textJoinDate.TabIndex = 8;
            // 
            // join_date
            // 
            join_date.AutoSize = true;
            join_date.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            join_date.Location = new Point(436, 214);
            join_date.Name = "join_date";
            join_date.Size = new Size(97, 26);
            join_date.TabIndex = 9;
            join_date.Text = "Join Date";
            // 
            // major
            // 
            major.AutoSize = true;
            major.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            major.Location = new Point(106, 279);
            major.Name = "major";
            major.Size = new Size(66, 26);
            major.TabIndex = 10;
            major.Text = "Major";
            // 
            // textMajor
            // 
            textMajor.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textMajor.Location = new Point(180, 279);
            textMajor.Name = "textMajor";
            textMajor.Size = new Size(201, 34);
            textMajor.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("Sitka Subheading", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(234, 30);
            label1.Name = "label1";
            label1.Size = new Size(339, 35);
            label1.TabIndex = 12;
            label1.Text = "Student Management System";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.LightGreen;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.ActiveCaptionText;
            saveBtn.Location = new Point(654, 274);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(86, 36);
            saveBtn.TabIndex = 13;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtnEvent;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Gray;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ActiveCaptionText;
            cancelBtn.Location = new Point(555, 274);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(86, 36);
            cancelBtn.TabIndex = 14;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtnEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(label1);
            Controls.Add(textMajor);
            Controls.Add(major);
            Controls.Add(join_date);
            Controls.Add(textJoinDate);
            Controls.Add(student_year);
            Controls.Add(textYear);
            Controls.Add(textAge);
            Controls.Add(student_age);
            Controls.Add(textName);
            Controls.Add(student_name);
            ForeColor = SystemColors.ControlLight;
            Name = "Form1";
            Text = "Student Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label student_name;
        private TextBox textName;
        private Label student_age;
        private TextBox textAge;
        private TextBox textYear;
        private Label student_year;
        private TextBox textJoinDate;
        private Label join_date;
        private Label major;
        private TextBox textMajor;
        private Label label1;
        private Button saveBtn;
        private Button cancelBtn;
    }
}
