namespace DotNetPractical.WinFormsApp
{
    partial class StudentListView
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
            studentGridView = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            student_name = new DataGridViewTextBoxColumn();
            student_age = new DataGridViewTextBoxColumn();
            student_year = new DataGridViewTextBoxColumn();
            join_date = new DataGridViewTextBoxColumn();
            major = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            SuspendLayout();
            // 
            // studentGridView
            // 
            studentGridView.AllowUserToAddRows = false;
            studentGridView.AllowUserToDeleteRows = false;
            studentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            studentGridView.BackgroundColor = Color.FromArgb(230, 241, 245);
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Columns.AddRange(new DataGridViewColumn[] { id, student_name, student_age, student_year, join_date, major });
            studentGridView.Location = new Point(0, 55);
            studentGridView.Name = "studentGridView";
            studentGridView.ReadOnly = true;
            studentGridView.Size = new Size(800, 396);
            studentGridView.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // student_name
            // 
            student_name.DataPropertyName = "student_name";
            student_name.HeaderText = "Name";
            student_name.Name = "student_name";
            student_name.ReadOnly = true;
            // 
            // student_age
            // 
            student_age.DataPropertyName = "student_age";
            student_age.HeaderText = "Age";
            student_age.Name = "student_age";
            student_age.ReadOnly = true;
            // 
            // student_year
            // 
            student_year.DataPropertyName = "student_year";
            student_year.HeaderText = "Student Year";
            student_year.Name = "student_year";
            student_year.ReadOnly = true;
            // 
            // join_date
            // 
            join_date.DataPropertyName = "join_date";
            join_date.HeaderText = "Join Date";
            join_date.Name = "join_date";
            join_date.ReadOnly = true;
            // 
            // major
            // 
            major.DataPropertyName = "major";
            major.HeaderText = "Major";
            major.Name = "major";
            major.ReadOnly = true;
            // 
            // StudentListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 241, 245);
            ClientSize = new Size(800, 450);
            Controls.Add(studentGridView);
            ForeColor = Color.FromArgb(0, 46, 93);
            Name = "StudentListView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentListView";
            Load += StudentListView_Load;
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentGridView;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn student_name;
        private DataGridViewTextBoxColumn student_age;
        private DataGridViewTextBoxColumn student_year;
        private DataGridViewTextBoxColumn join_date;
        private DataGridViewTextBoxColumn major;
    }
}