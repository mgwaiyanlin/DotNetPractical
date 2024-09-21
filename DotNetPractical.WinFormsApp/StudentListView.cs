using DotNetPractical.WinFormsApp.Models;
using DotNetPractical.WinFormsApp.Queries;
using DotNetPractical.WinFormsApp.Services;

namespace DotNetPractical.WinFormsApp
{
    public partial class StudentListView : Form
    {
        private readonly DapperService _dapperService;
        public StudentListView()
        {
            InitializeComponent();
            _dapperService = new DapperService(ConnectionsString.sqlConnectionStringBuilder.ConnectionString);
        }

        private void StudentListView_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            List<StudentModel> list = _dapperService.Query<StudentModel>(StudentQueries.ViewAllStudents);
            studentGridView.DataSource = list;
        }

        private void studentGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var studentId = Convert.ToInt32(studentGridView.Rows[e.RowIndex].Cells["id"].Value);

            if (studentId == -1) return;

            if (e.ColumnIndex == (int) EnumForClickEvents.Edit)
            {
                CreateStudentForm createStudentForm = new CreateStudentForm(studentId);
                createStudentForm.ShowDialog();

                LoadStudentData();
            }
            else if (e.ColumnIndex == (int) EnumForClickEvents.Delete)
            {
                var messageResult = MessageBox.Show(
                    $"Are you sure you wanna delete this {studentGridView.Rows[e.RowIndex].Cells["student_name"].Value}?",
                    "", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question
                );

                if (messageResult != DialogResult.Yes) return;
                
                deleteStudent(studentId);
            }
        }

        private void deleteStudent(int id)
        {
            int result = _dapperService.Execute(StudentQueries.DeleteStudent, new StudentModel { id = id });

            string message = result > 0 ? "Data deleted successfully." : "Failed to delete data.";

            MessageBox.Show(message, "Delete Respond Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LoadStudentData();
        }
    }
}
