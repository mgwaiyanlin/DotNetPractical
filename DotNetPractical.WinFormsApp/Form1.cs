using DotNetPractical.WinFormsApp.Models;
using DotNetPractical.WinFormsApp.Services;

namespace DotNetPractical.WinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly DapperService _dapperService;
        public Form1()
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
                student.student_age = textAge.Text;
                student.student_year = textYear.Text;
                student.join_date = textJoinDate.Text;
                student.major = textMajor.Text;

                _dapperService.Execute(StudentModel.StudentCreate ,student);

                return;

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
    }
}
