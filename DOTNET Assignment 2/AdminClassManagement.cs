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
    public partial class AdminClassManagement : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public AdminClassManagement()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        //Show all subjects
        private void button1_Click(object sender, EventArgs e)
        {
            AdminShowAllClasses adminShowAllSubjects = new AdminShowAllClasses();
            adminShowAllSubjects.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminAddClass subject = new AdminAddClass();
            subject.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDeleteClass menu = new AdminDeleteClass();
            menu.Show();
        }
    }
}
