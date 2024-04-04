using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class userEmo : UserControl
    {
        public userEmo()
        {
            InitializeComponent();
        }

        public void content(string a, Image b, string time, int state)
        {
            ava.Image = b;
            pictureBox.ImageLocation = a;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            lblTime.Text = time;
            if (state == 0)
            {
                lblTime.ForeColor = Color.Black;
            }
            else
            {
                lblTime.ForeColor = Color.White;
            }
        }
    }
}
