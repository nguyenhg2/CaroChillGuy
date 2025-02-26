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
    public partial class frmLogin1 : Form
    {
        public frmLogin1()
        {
            InitializeComponent();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            // Tạo một instance mới của frmChessBoard
            frmChessBoard frmChessBoard = new frmChessBoard();
            frmChessBoard.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
