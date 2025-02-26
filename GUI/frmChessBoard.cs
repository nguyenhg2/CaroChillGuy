using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CaroChill.Class;

namespace CaroChill.GUI
{
    public partial class frmChessBoard : Form
    {
        #region Properties
        ChessBoardManager chessBoard;
        #endregion
        public frmChessBoard()
        {
            InitializeComponent();
            chessBoard = new ChessBoardManager(pnlChessBoard);
            chessBoard.DrawChessBoard();
        }

      
    }
}
