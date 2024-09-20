using DotNetPractical.WinFormsApp.Models;
using DotNetPractical.WinFormsApp.Queries;
using DotNetPractical.WinFormsApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<StudentModel> list = _dapperService.Query<StudentModel>(StudentQueries.ViewAllStudents);
            studentGridView.DataSource = list;
        }
    }
}
