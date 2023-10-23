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
    public partial class AdminShowAllUsers : Form
    {
        public AdminShowAllUsers()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void AdminShowAllUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subjectManagementDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.subjectManagementDataSet.Login);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
