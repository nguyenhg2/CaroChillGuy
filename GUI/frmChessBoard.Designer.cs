namespace CaroChill.GUI
{
    partial class frmChessBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            càiĐặtToolStripMenuItem = new ToolStripMenuItem();
            pnlChessBoard = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { càiĐặtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // càiĐặtToolStripMenuItem
            // 
            càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            càiĐặtToolStripMenuItem.Size = new Size(70, 24);
            càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(289, 25);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(657, 636);
            pnlChessBoard.TabIndex = 1;
            // 
            // frmChessBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(pnlChessBoard);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmChessBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChessBoard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem càiĐặtToolStripMenuItem;
        private Panel pnlChessBoard;
    }
}