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
    public partial class AdminAddClass : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public AdminAddClass()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = dateTimePicker1.Value.ToShortTimeString();
            string t2 = dateTimePicker2.Value.ToShortTimeString();

            TimeSpan duration = DateTime.Parse(t2).Subtract(DateTime.Parse(t1));

            if (!String.IsNullOrWhiteSpace(textBox1.Text) && !String.IsNullOrWhiteSpace(comboBox1.Text) && !String.IsNullOrWhiteSpace(comboBox2.Text))
            {
                if (duration.TotalMinutes < 180)
                {
                    Subject subject = new Subject
                    {
                        name = textBox1.Text,
                        day = comboBox1.Text,
                        start_time = dateTimePicker1.Value,
                        end_time = dateTimePicker2.Value,
                        teacher = comboBox2.Text,
                    };
                    db.Subjects.InsertOnSubmit(subject);

                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Class successfully added to database.");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                else
                {
                    MessageBox.Show("Duration of class can not be longer than 3 hours.");
                }
            }
            else
            {
                MessageBox.Show("Fields cannot be empty.");
            }
        }

        private void AdminAddClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'subjectManagementDataSet1.Login1' table. You can move, or remove it, as needed.
            this.login1TableAdapter.Fill(this.subjectManagementDataSet1.Login1);
            // TODO: This line of code loads data into the 'subjectManagementDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.subjectManagementDataSet.Login);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
