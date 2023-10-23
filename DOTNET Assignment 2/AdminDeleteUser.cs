using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DOTNET_Assignment_2
{
    public partial class AdminDeleteUser : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public AdminDeleteUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var deleteUserDetails = from users in db.Logins where users.Id == Convert.ToInt32(textBox1.Text) select users;

                foreach (var user in deleteUserDetails)
                {
                    if (comboBox1.Text == user.role)
                    { 
                    db.Logins.DeleteOnSubmit(user);

                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("User successfully deleted from database");
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Must check box to proceed with deletion");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Must have selected a valid role or a valid ID");
                    }
                }

            }
            else
            {
                MessageBox.Show("Must check box to proceed with deletion");
            }
        }
    }
}
