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
    public partial class userInfo : UserControl
    {
        Color mouseEnter = Color.FromArgb(245, 250, 255);
        Color mouseLeave = Color.White;
        public userInfo()
        {
            InitializeComponent();
            this.MouseEnter += userInfo_MouseEnter;
            this.MouseLeave += userInfo_MouseLeave;
        }

        private void userInfo_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = mouseEnter;
        }

        private void userInfo_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = mouseLeave;
        }

        private string _avatarPath;
        public string AvatarPath
        {
            get { return _avatarPath; }
            set
            {
                _avatarPath = value;
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        // Thuộc tính Status
        private string _status;
        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
            }
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public void content(int id, string avaPath, string name, string status, int stateBrightness, int stateLanguage)
        {
            if (stateBrightness == 0)
            {
                this.BackColor = Color.FromArgb(245, 250, 255);
                label.ForeColor = Color.Black;
                text.ForeColor = Color.Black;
                mouseEnter = Color.WhiteSmoke;
                mouseLeave = Color.FromArgb(245, 250, 255);
            }else if (stateBrightness == 1)
            {
                this.BackColor = Color.FromArgb(12, 28, 46);
                label.ForeColor = Color.White;
                text.ForeColor = Color.White;
                mouseEnter = Color.FromArgb(14, 35, 60);
                mouseLeave = Color.FromArgb(12, 28, 46);
            }



            this.ID = id;
            this.Status = status;
            this.AvatarPath = avaPath;
            this.Name = name;
            ava.Image = Image.FromFile(avaPath);
            label.Text = name;
            if (status == "off")
            {
                statusImg.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\offline.png");
                text.Text = "Không hoạt động";
            }else
            {
                statusImg.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\online.png");
                text.Text = "Đang hoạt động";
            }

            if (stateLanguage == 0)
            {
                if (status == "off")
                {
                    text.Text = "Không hoạt động";
                }
                else
                {
                    text.Text = "Đang hoạt động";
                }
            }
            else if (stateLanguage == 1)
            {
                if (status == "off")
                {
                    text.Text = "Offline";
                }
                else
                {
                    text.Text = "Online";
                }
            }
        }

    }
}
