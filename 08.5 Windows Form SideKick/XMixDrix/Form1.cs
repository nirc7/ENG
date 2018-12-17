using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMixDrix
{
    public partial class Form1 : Form
    {
        int step = 1;
        bool IsXturn = true;

        public Form1()
        {
            InitializeComponent();
        }


        private void WinCheck()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "?")
            {
                MessageBox.Show("LINE - " + (IsXturn ? "X WINS" : "O WINS"));
                step = 10;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Button)sender).Name);

            if (9 < step || ((Button)sender).Text != "?")
            {
                return;
            }
            if (IsXturn)
            {
                ((Button)sender).Text = "X";
            }
            else
            {
                ((Button)sender).Text = "O";
            }
            WinCheck();

            IsXturn = !IsXturn;
            step++;
        }

        private void NewGame()
        {
            foreach (var control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    if (((Button)control).Name.StartsWith("button"))
                    {
                        ((Button)control).Text = "?";
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //opt1
            foreach (var control in Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    if (((Button)control).Name.StartsWith("button"))
                    {
                        ((Button)control).Text = "?";
                    }
                }
            }

            //opt2
            //button1.Text = button2.Text = "?";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
