using DotNetPractical.WinFormsApp.Models;
using DotNetPractical.WinFormsApp.Queries;
using DotNetPractical.WinFormsApp.Services;

namespace DotNetPractical.WinFormsApp
{
    public partial class CreateStudentForm : Form
    {
        private readonly DapperService _dapperService;
        private int _studentId;
        public CreateStudentForm()
        {
            InitializeComponent();
            _dapperService = new DapperService(ConnectionsString.sqlConnectionStringBuilder.ConnectionString);
            saveBtn.Visible = true;
            updateBtn.Visible = false;
        }

        public CreateStudentForm(int studentId)
        {
            InitializeComponent();
            _studentId = studentId;
            _dapperService = new DapperService(ConnectionsString.sqlConnectionStringBuilder.ConnectionString);

            var studentModel = _dapperService.Query<StudentModel>(StudentQueries.ViewOneStudent, new StudentModel { id = _studentId }).FirstOrDefault()!;

            if (studentModel != null)
            {
                textName.Text = studentModel.student_name;
                textAge.Text = Convert.ToString(studentModel.student_age);
                textYear.Text = Convert.ToString(studentModel.student_year);
                textJoinDate.Text = studentModel.join_date;
                textMajor.Text = studentModel.major;
            }
            else
            {
                MessageBox.Show("No student found with the provided ID.");
            }

            saveBtn.Visible = false;
            updateBtn.Visible = true;
        }

        private void saveBtnEvent(object sender, EventArgs e)
        {
            try
            {
                StudentModel student = new StudentModel();
                student.student_name = textName.Text;
                student.student_age = Convert.ToInt32(textAge.Text);
                student.student_year = Convert.ToInt32(textYear.Text);
                student.join_date = textJoinDate.Text;
                student.major = textMajor.Text;

                int result = _dapperService.Execute(StudentQueries.CreateStudent, student);

                clearInputsEvent();

                if (result > 0)
                {
                    MessageBox.Show("Data Added Successfully!");
                }
                else
                {
                    MessageBox.Show("Error: Data not saved! Something went wrong!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cancelBtnEvent(object sender, EventArgs e)
        {
            clearInputsEvent();
        }

        private void clearInputsEvent()
        {
            textName.Clear();
            textAge.Clear();
            textYear.Clear();
            textJoinDate.Clear();
            textMajor.Clear();

            textName.Focus();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StudentModel student = new StudentModel();
                student.id = _studentId;
                student.student_name = textName.Text;
                student.student_age = Convert.ToInt32(textAge.Text);
                student.student_year = Convert.ToInt32(textYear.Text);
                student.join_date = textJoinDate.Text;
                student.major = textMajor.Text;

                int result = _dapperService.Execute(StudentQueries.UpdateStudent, student);

                string message = result > 0 ? "Updated successfully." : "Failed to update!";

                MessageBox.Show(message);

                this.Close();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
