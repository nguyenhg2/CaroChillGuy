using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CaroChill.Class
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.chessBoard = chessBoard;
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(j * Cons.CHESS_WIDTH, i * Cons.CHESS_HEIGHT),
                    };
                    chessBoard.Controls.Add(btn);
                }
            }
        }
        #endregion
    }
}
