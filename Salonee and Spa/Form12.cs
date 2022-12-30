using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Salonee_and_Spa
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWork.Text) || string.IsNullOrEmpty(txtStatus.Text))
            return;
            ListViewItem item = new ListViewItem(txtWork.Text);
            item.SubItems.Add(txtStatus.Text);
            listView.Items.Add(item);
            txtWork.Clear();
            txtStatus.Clear();
            txtWork.Focus();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
                listView.Items.Remove(listView.SelectedItems[0]);
        }
    }
}
