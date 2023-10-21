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
    public partial class Form1 : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Login";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = (from s in db.Logins where s.Id == Convert.ToInt32(textBox1.Text) select s).First();

            if (user.password == textBox2.Text)
            {
                if (user.role == "Admin")
                {
                    this.Hide();
                    AdminForm menu = new AdminForm();
                    menu.Show();
                }
                if (user.role == "Teacher")
                {
                    this.Hide();
                    TeacherForm menu = new TeacherForm();
                    menu.Show();
                }
                if (user.role == "Student")
                {
                    this.Hide();
                    StudentForm menu = new StudentForm();
                    menu.Show();
                }
            }
            else
            {
                MessageBox.Show("Error matey");
            }
        }
    }
}
