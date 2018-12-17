using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsayHello_Click(object sender, EventArgs e)
        {
            lblHello.Text = "hello " + txtName.Text + ", " + DateTime.Now.AddDays(-1).ToShortDateString();
            timer1.Enabled = !timer1.Enabled;
        }

        private void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHello.Text = cmbCars.SelectedIndex + ", " + cmbCars.SelectedItem;
            if (cmbCars.SelectedItem.ToString().ToUpper() == "porsche".ToUpper())
            {
                ckbCoupon.Checked = true;
            }
        }

        private void ckbCoupon_CheckedChanged(object sender, EventArgs e)
        {
            lblHello.Text = ckbCoupon.Checked.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHello.Text = "";
            foreach (var item in checkedListBox1.CheckedItems)
            {

                lblHello.Text += item + ", ";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lblHello.Text = radioButton4.Checked ? "rtn4 TRUE" : "rtn4 FALSE";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblHello.Text = dateTimePicker1.Value.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("hello avi", "GOOD MORNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel!");
            }
            else
            {
                MessageBox.Show("OK:)");
            }
        }
    }
}
