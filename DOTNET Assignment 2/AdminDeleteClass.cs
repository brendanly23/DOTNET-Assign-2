using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTNET_Assignment_2
{
    public partial class AdminDeleteClass : Form
    {
        public AdminDeleteClass()
        {
            InitializeComponent();
        }

        private void AdminDeleteSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subjectManagementDataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.subjectManagementDataSet.Subject);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
