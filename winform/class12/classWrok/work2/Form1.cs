using System;
using System.Windows.Forms;

namespace work2
{
    public partial class FormCircle : Form
    {
        public FormCircle()
        {
            InitializeComponent();
        }

        private void FormCircle_Load(object sender, EventArgs e)
        {
            AcceptButton = btnCircle;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            try
            {
                int r = int.Parse(txtCircle.Text.Trim());
                if (r > 0)
                {
                    MessageBox.Show("结果是:" + Math.Round(Math.PI * Math.Pow(r, 2), 2));
                }
            }
            catch
            {
                MessageBox.Show("输入的内容有误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally {
                txtCircle.Text = "";
            }
        }
    }
}
