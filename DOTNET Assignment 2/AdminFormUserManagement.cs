﻿using System;
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
    public partial class AdminFormUserManagement : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public AdminFormUserManagement()
        {
            InitializeComponent();
        }

        //Add a user into the Database
        private void button1_Click(object sender, EventArgs e)
        {
            AdminAddUser adminAddUser = new AdminAddUser();
            adminAddUser.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminDeleteUser menu = new AdminDeleteUser();
            menu.Show();
        }

        //Show all users
        private void button2_Click(object sender, EventArgs e)
        {
            AdminShowAllUsers menu = new AdminShowAllUsers();
            menu.Show();
        }

        private void AdminFormUserManagement_Load(object sender, EventArgs e)
        {

        }

        //Exit form
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
