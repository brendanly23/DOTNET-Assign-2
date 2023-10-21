using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTNET_Assignment_2
{
    public partial class AdminAddUser : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public AdminAddUser()
        {
            InitializeComponent();
        }

        //Adds a user to DB
        private void button1_Click(object sender, EventArgs e)
        {
            var lastID = db.Logins.ToArray().LastOrDefault().Id;

            Login login = new Login
            {
                Id = lastID + 1,
                username = textBox1.Text,
                password = null,
                role = comboBox1.Text
            };

            db.Logins.InsertOnSubmit(login);

            try
            {
                db.SubmitChanges();
                MessageBox.Show("User successfully added to database.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            this.Hide();
        }

        private void AdminAddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subjectManagementDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.subjectManagementDataSet.Login);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
