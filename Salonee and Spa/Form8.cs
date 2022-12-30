using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Salonee_and_Spa
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 objback = new Form1();
            objback.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Registration = new Form6();
            Registration.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Enter the username");
            }

            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Enter the password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-7B5T46D\\SQLEXPRESS;Initial Catalog=SS;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select* from customer where username= @username and password = @password", con);
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Username or password is invalid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }


                Form9 Services = new Form9();
                Services.Show();
                this.Hide();
            }

        }
    }
}
