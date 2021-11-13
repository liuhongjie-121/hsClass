using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace submitForm
{
    public partial class luckyForm : Form
    {
        public luckyForm()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        private void btnStart_Click(object sender, EventArgs e)
        {
            timeAdd1.Start();                        
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timeAdd1.Stop();
            int labNum = 0;
            foreach (Control item in Controls) {              
                if (item is Label) {
                    if (item.Text == "8") labNum++;
                }
            }
            if (labNum == 3) MessageBox.Show("中奖了！");
            else MessageBox.Show("没中奖");
        }

        private void timeAdd1_Tick(object sender, EventArgs e)
        {
            labChange1.Text = rd.Next(0, 9).ToString();
            labChange2.Text = rd.Next(0, 9).ToString();
            labChange3.Text = rd.Next(0, 9).ToString();
        }
    }
}
