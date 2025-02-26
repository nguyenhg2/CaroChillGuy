using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace CaroChill.GUI
{
    partial class frmLogin1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnOK = new Button();
            pnlLogin1 = new Panel();
            comboBox1 = new ComboBox();
            button1 = new Button();
            txtUsername = new Guna2TextBox();
            pnlLogin1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.AutoSize = true;
            btnOK.BackColor = Color.ForestGreen;
            btnOK.BackgroundImageLayout = ImageLayout.Stretch;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnOK.ForeColor = Color.PeachPuff;
            btnOK.Location = new Point(144, 298);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(108, 38);
            btnOK.TabIndex = 0;
            btnOK.Text = "ĐĂNG NHẬP";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // pnlLogin1
            // 
            pnlLogin1.BackgroundImage = Properties.Resources._8593aa4b03478c7b1b3846c451b1ec521;
            pnlLogin1.BackgroundImageLayout = ImageLayout.Stretch;
            pnlLogin1.Controls.Add(comboBox1);
            pnlLogin1.Controls.Add(button1);
            pnlLogin1.Controls.Add(btnOK);
            pnlLogin1.Controls.Add(txtUsername);
            pnlLogin1.Dock = DockStyle.Fill;
            pnlLogin1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlLogin1.Location = new Point(0, 0);
            pnlLogin1.Margin = new Padding(2);
            pnlLogin1.Name = "pnlLogin1";
            pnlLogin1.Size = new Size(388, 450);
            pnlLogin1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ControlLightLight;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dễ", "Trung bình", "Khó" });
            comboBox1.Location = new Point(102, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(190, 36);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Chọn cấp độ";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(352, 2);
            button1.Name = "button1";
            button1.Size = new Size(34, 32);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderRadius = 4;
            txtUsername.BorderThickness = 0;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HideSelection = false;
            txtUsername.IconLeft = Properties.Resources.login;
            txtUsername.IconLeftCursor = Cursors.IBeam;
            txtUsername.IconLeftOffset = new Point(7, 1);
            txtUsername.IconLeftSize = new Size(25, 24);
            txtUsername.ImeMode = ImeMode.NoControl;
            txtUsername.Location = new Point(102, 89);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderForeColor = Color.Black;
            txtUsername.PlaceholderText = "Tên đăng nhập";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(190, 39);
            txtUsername.TabIndex = 1;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.UseWaitCursor = true;
            // 
            // frmLogin1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(388, 450);
            Controls.Add(pnlLogin1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin1";
            TransparencyKey = Color.FromArgb(25, 25, 112);
            pnlLogin1.ResumeLayout(false);
            pnlLogin1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Panel pnlLogin1;
        private Guna2TextBox txtUsername;
        private Button button1;
        private ComboBox comboBox1;
    }
}