using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DOTNET_Assignment_2
{
    public partial class AdminDeleteClass : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var deleteClass = from subj in db.Subjects where subj.Id == Convert.ToInt32(textBox1.Text) select subj;

                foreach (var subj in deleteClass)
                {
                    db.Subjects.DeleteOnSubmit(subj);

                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Class successfully deleted from database");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Must check box to proceed with deletion");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please confirm before deleting.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
