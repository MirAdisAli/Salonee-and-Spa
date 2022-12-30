using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace Salonee_and_Spa
{
    public partial class Form6 : Form
    {
        //string connectionString = @"Data Source=DESKTOP-7B5T46D\\SQLEXPRESS;Initial Catalog=SS;Integrated Security=True;";

        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtContact.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                    MessageBox.Show("Please fill mandatory fields");
                else if (txtPassword.Text != txtConfirmPassword.Text)
                    MessageBox.Show("Password do not match");
                else
                {
                string connectionString = @"Data Source=DESKTOP-7B5T46D\SQLEXPRESS;Initial Catalog=SS;Integrated Security=True;";
    
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Contact", txtContact.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Registration is successfull");
                        Clear();

                    }
                }

        }
        void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtContact.Text = txtAddress.Text = txtUsername.Text = txtPassword.Text = txtConfirmPassword.Text = "";
        }
    }
}
