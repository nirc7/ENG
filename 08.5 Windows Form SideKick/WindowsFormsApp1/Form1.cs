using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            string input = txtNum.Text;
            int num = int.Parse(input);
            lblRes.Text = (num + 1).ToString();
        }

        private void btnAddOne_MouseEnter(object sender, EventArgs e)
        {
            lblRes.Text = "shalom";
        }

        private void avi(object sender, EventArgs e)
        {
            lblRes.Text = "bye";
        }

        private void chbCoupon_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCoupon.Checked)
            {
                lblRes.Text = "OK";
            }
            else
            {
                lblRes.Text = "not ok";
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if ( ! ('0' <= txtNum.Text[txtNum.Text.Length - 1] &&
                txtNum.Text[txtNum.Text.Length - 1] <= '9'))
            {
                txtNum.Text = txtNum.Text.Substring(0, txtNum.Text.Length-1);
            }

            lblRes.Text = txtNum.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRes.Text = comboBox1.SelectedIndex + ", " + comboBox1.SelectedItem;
        }

        private void btnChbListBoxClothes_Click(object sender, EventArgs e)
        {
            lblRes.Text = "";
            foreach (var item in clbClothes.CheckedItems)
            {
                lblRes.Text += item + ", ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("kia");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblRes.Text = monthCalendar1.SelectionStart.Date.AddDays(1).ToString();
        }

       
    }
}
