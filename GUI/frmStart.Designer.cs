namespace CaroChill.GUI
{
    partial class frmStart
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
            pnlStart = new Panel();
            btnExitGame = new Button();
            btn1Player = new Button();
            btnTheRules = new Button();
            btn2Player = new Button();
            pnlStart.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStart
            // 
            pnlStart.BackgroundImage = Properties.Resources.background;
            pnlStart.BackgroundImageLayout = ImageLayout.Stretch;
            pnlStart.Controls.Add(btnExitGame);
            pnlStart.Controls.Add(btn1Player);
            pnlStart.Controls.Add(btnTheRules);
            pnlStart.Controls.Add(btn2Player);
            pnlStart.Dock = DockStyle.Fill;
            pnlStart.Location = new Point(0, 0);
            pnlStart.Name = "pnlStart";
            pnlStart.Size = new Size(1262, 673);
            pnlStart.TabIndex = 0;
            // 
            // btnExitGame
            // 
            btnExitGame.BackColor = Color.ForestGreen;
            btnExitGame.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            btnExitGame.Location = new Point(963, 368);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(223, 60);
            btnExitGame.TabIndex = 5;
            btnExitGame.Text = "EXIT GAME";
            btnExitGame.UseVisualStyleBackColor = false;
            btnExitGame.Click += btnExitGame_Click;
            // 
            // btn1Player
            // 
            btn1Player.BackgroundImage = Properties.Resources._1player;
            btn1Player.BackgroundImageLayout = ImageLayout.Stretch;
            btn1Player.Location = new Point(279, 272);
            btn1Player.Name = "btn1Player";
            btn1Player.Size = new Size(197, 235);
            btn1Player.TabIndex = 4;
            btn1Player.UseVisualStyleBackColor = true;
            btn1Player.Click += btn1Player_Click;
            // 
            // btnTheRules
            // 
            btnTheRules.BackColor = Color.ForestGreen;
            btnTheRules.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Strikeout, GraphicsUnit.Point, 0);
            btnTheRules.Location = new Point(963, 272);
            btnTheRules.Name = "btnTheRules";
            btnTheRules.Size = new Size(223, 60);
            btnTheRules.TabIndex = 2;
            btnTheRules.Text = "THE RULES";
            btnTheRules.UseVisualStyleBackColor = false;
            btnTheRules.Click += btnTheRules_Click;
            // 
            // btn2Player
            // 
            btn2Player.BackgroundImage = Properties.Resources._2player;
            btn2Player.BackgroundImageLayout = ImageLayout.Stretch;
            btn2Player.Location = new Point(610, 272);
            btn2Player.Name = "btn2Player";
            btn2Player.Size = new Size(197, 235);
            btn2Player.TabIndex = 0;
            btn2Player.UseVisualStyleBackColor = true;
            // 
            // frmStart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(pnlStart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmStart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmStart";
            pnlStart.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlStart;
        private Button btn1Player;
        private Button btnTheRules;
        private Button btn2Player;
        private Button btnExitGame;
    }
}