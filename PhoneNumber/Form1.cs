using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneNumber
{
    public partial class Form1 : Form
    {
        readonly string fmt = "(000) 000-0000";
        private long Number = 0;
        public long number {
            get { return Number; }
            set {
                if (value < 10000000000 && value >= 0) {
                    Number = value;
                } else {
                    // do nothing
                }
            }
        }
        Random r = new Random();

        public string number_formatted {
            get {
                return number.ToString(fmt);
            }
        }

        public void updateGUI()
        {
            phone.Text = number_formatted;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void cb_left_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_right.Checked) {
                number = number * (number / 10000000);
            } else {
                number = number / 2;
            }
            updateGUI();
        }

        private void cb_right_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_left.Checked) {
                number = number * 2;
            } else {
                number = number / 2;
            }
            updateGUI();
        }

        public int tb_top_val=0;
        public int tb_bot_val=0;
        private void tb_top_Scroll(object sender, EventArgs e)
        {
            int change = tb_top.Value - tb_top_val;
            number = number + change;
            updateGUI();
            tb_top_val = tb_top.Value;
        }

        private void tb_bottom_Scroll(object sender, EventArgs e)
        {
            int change = tb_bottom.Value - tb_bot_val;
            number = number + change;
            updateGUI();
            tb_bot_val = tb_bottom.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (r.Next(0, 10) != 8) {
                number++;
            } else {
                number--;
            }
            updateGUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (r.Next(0, 10) != 8) {
                number--;
            } else {
                number++;
            }
            updateGUI();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
