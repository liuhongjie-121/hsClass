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
    public partial class heroIndexForm : Form
    {
        public heroIndexForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProgressBar pro = pgbIndex;
            if (pro.Value < pro.Maximum) pro.Value += 5;
            else Visible = false;
            labNow.Text = pgbIndex.Value.ToString();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            ProgressBar pro = pgbIndex;
            if (pro.Value > pro.Minimum) pro.Value -= 5;
            else Visible = false;
            labNow.Text = pgbIndex.Value.ToString();
        }

        private void heroIndexForm_Load(object sender, EventArgs e)
        {
            labNow.Text = pgbIndex.Value.ToString();
        }
    }
}
