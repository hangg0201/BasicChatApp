using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace ChatApp
{
    public partial class userImage : UserControl
    {
        public userImage()
        {
            InitializeComponent();
        }

        public void content(PictureBox a, Image b, string time, int state)
        {
            ava.Image = b;
            pnImages.Controls.Add(a);
            a.Click += new EventHandler(previewImage);
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

        public void previewImage(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            preview previewForm = new preview(pictureBox.Image);
            previewForm.ShowDialog();
        }

    }
}
