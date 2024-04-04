using System;
using System.CodeDom.Compiler;
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
    public partial class userText : UserControl
    {
        public userText()
        {
            InitializeComponent();
        }

    
        public void content(string s, Image a, string time, int state)
        {
            messBox.Text = s;
            ava.Image = a;
            lblTime.Text = time;
            if (state == 0)
            {
                lblTime.ForeColor = Color.Black;
                messBox.BackColor = Color.FromArgb(108, 172, 228);
                messBox.ForeColor = Color.White;
            }
            else
            {
                lblTime.ForeColor= Color.White;
                messBox.BackColor = Color.FromArgb(226, 242, 255);
                messBox.ForeColor = Color.Black;
            }


        }

        public bool selectText(string s)
        {
            string temp = messBox.Text;
            messBox.Text = temp;
            int index = messBox.Text.IndexOf(s);
            if (index == -1)
            {
                return false;
            }
            messBox.SelectionStart = index;
            messBox.SelectionLength = s.Length;
            messBox.SelectionBackColor = Color.FromArgb(49, 141, 221);
            return true;
        }
    }
}
