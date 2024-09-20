using DotNetPractical.WinFormsApp.Models;
using DotNetPractical.WinFormsApp.Queries;
using DotNetPractical.WinFormsApp.Services;

namespace DotNetPractical.WinFormsApp
{
    public partial class CreateStudentForm : Form
    {
        private readonly DapperService _dapperService;
        public CreateStudentForm()
        {
            InitializeComponent();
            _dapperService = new DapperService(ConnectionsString.sqlConnectionStringBuilder.ConnectionString);
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
                } else
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

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
