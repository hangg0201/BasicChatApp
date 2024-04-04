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
    public partial class userVideo : UserControl
    {
        public userVideo()
        {
            InitializeComponent();
        }

        public void content(string s, Image a, string time, int state)
        {
            ava.Image = a;
            video userBox = new video();
            userBox.content(s);
            pnVideos.Controls.Add(userBox);
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

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
