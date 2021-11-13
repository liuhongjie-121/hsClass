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
    public partial class regisiterForm : Form
    {
        public regisiterForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            bool IsComplete = false;
            foreach (Control item in groupUser.Controls)
            {
                if (!string.IsNullOrEmpty(item.Text.Trim()))
                {
                    IsComplete = true;
                }
                else IsComplete = false;
            }
                if (IsComplete) MessageBox.Show("注册完成");
            else MessageBox.Show("还有必填项未填写");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupUser.Controls)
            {
                item.Text = "";
            }
            foreach (CheckBox item2 in groupHobby.Controls)
            {
                item2.Checked = false;
            }
            rdoSexMan.Checked = true;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            rdoSexMan.Checked = true;
        }
    }
}
