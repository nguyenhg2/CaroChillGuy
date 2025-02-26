using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CaroChill.GUI
{
    public partial class frmTheRules : Form
    {
        int currentIndex = 1;


        public frmTheRules()
        {
            InitializeComponent();

        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            // Chuyển tới hình ảnh tiếp theo
            currentIndex++;
            UpdateImage();
            if (currentIndex == 7)
            {
                btnNext.Visible = false;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {   
            btnNext.Visible = true;
            currentIndex--;
            UpdateImage();
            if (currentIndex == 1)
            {
                btnBack.Visible = false;
            }
        }

        private void UpdateImage()
        {
            //// Cập nhật hình ảnh trong PictureBox tùy theo chỉ mục hiện tại
            switch (currentIndex % 10)
            {
                case 1:
                    //btnBack.Visible = false;
                    picTheRules1.Visible = true;
                    picTheRules2.Visible = false;
                    picTheRules3.Visible = false;
                    picTheRules4.Visible = false;
                    picTheRules5.Visible = false;
                    picTheRules6.Visible = false;
                    picTheRules7.Visible = false;
                    break;
                case 2:
                    picTheRules1.Visible = false;
                    picTheRules2.Visible = true;
                    picTheRules3.Visible = false;
                    picTheRules4.Visible = false;
                    picTheRules5.Visible = false;
                    picTheRules6.Visible = false;
                    picTheRules7.Visible = false;
                    break;
                case 3:
                    picTheRules1.Visible = false;
                    picTheRules2.Visible = false;
                    picTheRules3.Visible = true;
                    picTheRules4.Visible = false;
                    picTheRules5.Visible = false;
                    picTheRules6.Visible = false;
                    picTheRules7.Visible = false;
                    break;
                case 4:
                    picTheRules1.Visible = false;
                    picTheRules2.Visible = false;
                    picTheRules3.Visible = false;
                    picTheRules4.Visible = true;
                    picTheRules5.Visible = false;
                    picTheRules6.Visible = false;
                    picTheRules7.Visible = false;
                    break;
                case 5:
                    picTheRules1.Visible = false;
                    picTheRules2.Visible = false;
                    picTheRules3.Visible = false;
                    picTheRules4.Visible = false;
                    picTheRules5.Visible = true;
                    picTheRules6.Visible = false;
                    picTheRules7.Visible = false;
                    break;
                case 6:
                    picTheRules1.Visible = false;
                    picTheRules2.Visible = false;
                    picTheRules3.Visible = false;
                    picTheRules4.Visible = false;
                    picTheRules5.Visible = false;
                    picTheRules6.Visible = true;
                    picTheRules7.Visible = false;
                    break;
                case 7:
                   // btnNext.Visible = false;
                    picTheRules1.Visible = false;
                    picTheRules2.Visible = false;
                    picTheRules3.Visible = false;
                    picTheRules4.Visible = false;
                    picTheRules5.Visible = false;
                    picTheRules6.Visible = false;
                    picTheRules7.Visible = true;
                    break;

            }
        }

        
    }
}
