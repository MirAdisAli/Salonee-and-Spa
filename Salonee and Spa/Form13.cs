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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtWork_TextChanged(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-7B5T46D\SQLEXPRESS;Initial Catalog=SS;Integrated Security=True;");
        private void Clear()
        {
            BeauticianNameTb.Text = "";
            IncomeAmountTb.Text = "";
            IncDate.Text = "";
     
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (label.Text == "" || IncomeAmountTb.Text == "")
                MessageBox.Show("Missing Information");
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into IncomeTbl(BeaName,IncAmt,IncDate) values(@BN,@IA,@ID)", Con);
                    cmd.Parameters.AddWithValue("@BN", BeauticianNameTb.Text);
                    cmd.Parameters.AddWithValue("@IA", IncomeAmountTb.Text);
                    cmd.Parameters.AddWithValue("@ID", IncDate.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income Added");
                    Con.Close();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
    }

