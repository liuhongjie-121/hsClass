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
    public partial class heroLoginForm : Form
    {
        public heroLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text.Trim();
            string Pass = txtPass.Text.Trim();
            if (!string.IsNullOrEmpty(Name) & !string.IsNullOrEmpty(Pass)) {
                Hide();
                heroIndexForm hero = new heroIndexForm();
                hero.Show();                
                // Application.ExitThread();
            }
        }
    }
}
