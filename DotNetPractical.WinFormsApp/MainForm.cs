
namespace DotNetPractical.WinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateStudentForm createStudentForm = new CreateStudentForm();
            createStudentForm.ShowDialog();
        }

        private void viewStudentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListView studentListView = new StudentListView();
            studentListView.Show();
        }
    }
}
