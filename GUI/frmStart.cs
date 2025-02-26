using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroChill.GUI
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát game?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnTheRules_Click(object sender, EventArgs e)
        {
            frmTheRules fromTheRules = new frmTheRules();
            fromTheRules.StartPosition = FormStartPosition.CenterParent;
            fromTheRules.ShowDialog();
        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            frmLogin1 frmLogin1 = new frmLogin1();
            frmLogin1.StartPosition = FormStartPosition.CenterScreen;
            frmLogin1.ShowDialog();
        }
    }
}
