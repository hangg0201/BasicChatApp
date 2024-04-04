using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using WMPLib;
using System.Security.Policy;

namespace ChatApp
{
    public partial class FormChat : Form
    {
        bool emojiClick = false;
        DataTable dt = new DataTable();
        int chatID;
        int currentID = 0;
        public int stateBrightness = 0;
        public int stateLanguge = 0;
        public FormChat()
        {
            InitializeComponent();
        }

        public FormChat(string currentEmail, int state)
        {
            InitializeComponent();
            stateLanguge = state;
            string[] lines = File.ReadAllLines("C:\\university\\cs511\\chatapp\\data\\user\\" + "user.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('*');
                if (parts.Length < 5 )
                {
                    continue;
                }
                int id = int.Parse(parts[0]);
                string avatarPath = parts[1];
                string email = parts[3];
                string name = parts[5];
                if (currentEmail == email)
                {
                    currentID = id;
                    usrAva.Image = Image.FromFile(avatarPath);
                    usrName.Text = name;
                    usrText.Text = "Đang hoạt động";
                    usrStatus.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\online.png");
                }
            }
            resetUserPanelLanguage();

        }


        void InitializeDataTable()
        {
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("AvatarPath", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            string[] lines = File.ReadAllLines("C:\\university\\cs511\\chatapp\\data\\user\\" + "user.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split('*');
                if (parts.Length < 5 )
                {
                    continue;
                }
                int id = int.Parse(parts[0]);
                string avatarPath = parts[1];
                string status = parts[2];
                string email = parts[3];
                string pass = parts[4];
                string name = parts[5];
                Console.WriteLine(id);
                dt.Rows.Add(id, avatarPath, status, email, pass, name);
            }

        }


        private void FormChat_Load(object sender, EventArgs e)
        {
            if (stateLanguge == 1)
            {
                english.Checked = true;
            }else
            {
                vietnamese.Checked = true;
            }    
            light.Checked = true;
            emoPanel.SendToBack();
            emo1.Click += new EventHandler(sendEmo);
            emo2.Click += new EventHandler(sendEmo);
            emo3.Click += new EventHandler(sendEmo);
            emo4.Click += new EventHandler(sendEmo);
            emo5.Click += new EventHandler(sendEmo);
            emo6.Click += new EventHandler(sendEmo);
            emo7.Click += new EventHandler(sendEmo);
            emo8.Click += new EventHandler(sendEmo);
            emo9.Click += new EventHandler(sendEmo);
            emo10.Click += new EventHandler(sendEmo);
            InitializeDataTable();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                int id = (int)row["ID"];
                string avatarPath = (string)row["AvatarPath"];
                string status = (string)row["Status"];
                string email = (string)row["Email"];
                string pass = (string)row["Password"];
                string name = (string)row["Name"];
                if (id != currentID)
                {
                    userInfo usr = new userInfo();
                    usr.content(id, avatarPath, name, status, stateBrightness, stateLanguge);
                    pnUsers.Controls.Add(usr);
                    usr.Click += new EventHandler(UserClick);
                    chatID = id;
                    messAva.Image = Image.FromFile(avatarPath);
                    messName.Text = name;
                    restorePanel(currentID, chatID);

                    if (status == "off")
                    {
                        messStatus.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\offline.png");
                        if (stateLanguge == 0)
                        {
                            messText.Text = "Không hoạt động";
                        }
                        else
                        {
                            messText.Text = "Offline";
                        }
                    }
                    else
                    {
                        messStatus.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\online.png");
                        if (stateLanguge == 0)
                        {
                            messText.Text = "Đang hoạt động";
                        }
                        else
                        {
                            messText.Text = "Online";
                        }
                    }
                    string pathDataChat = "C:\\university\\cs511\\chatapp\\data\\history\\" + "chat" + "from" + currentID + "to" + chatID + ".txt";
                    if (!File.Exists(pathDataChat))
                    {
                        continue;
                    }
                    string[] lines = File.ReadAllLines(pathDataChat);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('*');
                        if (parts.Length < 5) continue;
                        string type = parts[0];
                        if (type == "video")
                        {
                            string files = parts[3];
                            string[] url = files.Split('&');
                            foreach(string u in url)
                            {
                                video v = new video();
                                v.content(u);
                                pnVideos.Controls.Add(v);
                            }
                        }
                        else if (type == "image")
                        {
                            string files = parts[3];
                            string[] images = files.Split('&');
                            foreach (string image in images)
                            {
                                PictureBox a = new PictureBox();
                                a.Image = Image.FromFile(image);
                                a.SizeMode = PictureBoxSizeMode.Zoom;
                                a.Size = new Size(150, 150);
                                a.Click += new EventHandler(previewImage);
                                pnImages.Controls.Add(a);
                            }
                        }
                    }
                }

            }

        }
        void restorePanel(int currentID, int chatID)
        {
            pnContents.Controls.Clear();
            string pathDataChat = "C:\\university\\cs511\\chatapp\\data\\history\\" + "chat" + "from" + currentID + "to" + chatID + ".txt";
            if(!File.Exists(pathDataChat))
            {
                return;
            }
            string[] lines = File.ReadAllLines(pathDataChat);
            foreach(string line in lines)
            {
                string[] parts = line.Split('*');
                if (parts.Length < 5) continue;
                string type = parts[0];
                if (type == "text")
                {
                    string text = parts[3];
                    string time = parts[4];
                    SendText(text, time);
                }else if (type == "video")
                {
                    string files = parts[3];
                    string time = parts[4];
                    string[] url = files.Split('&');
                    SendVideo(url, time);
                }else if(type == "image")
                {
                    string files = parts[3];
                    string time = parts[4];
                    string[] images = files.Split('&');
                    SendImage(images, time);
                }
                else if(type=="emo")
                {
                    string file = parts[3];
                    string time = parts[4];
                    SendEmo(file, time);
                }
            }
        }

        void UserClick(object sender, EventArgs e)
        {
            pnContent.BringToFront();
            pnContent.Visible = true;
            pnSettings.Visible = false;
            panelGallery.Visible = false;
            pnSettings.SendToBack();
            panelGallery.SendToBack();
            userInfo usr = (userInfo)sender;
            messAva.Image = Image.FromFile(usr.AvatarPath);
            messName.Text = usr.Name;
            if (usr.Status == "off")
            {
                messStatus.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\offline.png");
                if (stateLanguge == 0)
                {
                    messText.Text = "Không hoạt động";
                }else
                {
                    messText.Text = "Offline";
                }
            }
            else
            {
                messStatus.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\online.png");
                if (stateLanguge == 0)
                {
                    messText.Text = "Đang hoạt động";
                }
                else
                {
                    messText.Text = "Online";
                }
            }
            chatID = usr.ID;
            restorePanel(currentID, chatID);
            panelGallery.Visible = false;
        }

        void SendText(string text, string time)
        {
            userText uct = new userText();
            this.pnContents.Controls.Add(uct);
            uct.content(text, usrAva.Image, time, stateBrightness);
            double size = 100;
            if (Convert.ToDouble(text.Length) > 50)
            {
                size = 80 + 28 * Math.Round(Convert.ToDouble(text.Length) / 50 + 0.5);
            }
            uct.Size = new System.Drawing.Size(800, Convert.ToInt32(size));
        }

        void SendEmo(string i, string time)
        {
            userEmo uct = new userEmo();
            this.pnContents.Controls.Add(uct);
            uct.content(i, usrAva.Image, time, stateBrightness);
            uct.Size = new System.Drawing.Size(800, 80);
        }

        void SendImage(string[] filenames, string time)
        {
            userImage uct = new userImage();
            this.pnContents.Controls.Add(uct);
            int num = 0;
            int size = 150;
            string txtFile = "";
            foreach (string filename in filenames)
            {
                PictureBox picBox = new PictureBox();
                picBox.Image = Image.FromFile(filename);
                picBox.SizeMode = PictureBoxSizeMode.Zoom;
                picBox.Size = new Size(100, 100);
                txtFile += "*" + filename;

                uct.content(picBox, usrAva.Image, time, stateBrightness);
                num++;
            }
            size = 170 + ((num - 1) / 2) * 100;
            uct.Size = new Size(800, size);
        }

        void SendVideo(string[] url, string time)
        {
            userVideo uct = new userVideo();
            this.pnContents.Controls.Add(uct);
            int num = 0;
            int size = 220;
            foreach(string u in  url)
            {
                uct.content(u, usrAva.Image, time, stateBrightness);
                num += 1;
            }
            size = 200 + ((num - 1) / 2) * 150;
            uct.Size = new System.Drawing.Size(700, size);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            if (txtChat.Text == "")
            {
                return;
            }
            SendText(txtChat.Text, time);
            string pathDataChat = "C:\\university\\cs511\\chatapp\\data\\history\\" + "chat" + "from" + currentID + "to" + chatID + ".txt";
            StreamWriter sw = new StreamWriter(pathDataChat, true);
            sw.WriteLine("text*" + currentID.ToString() + "*" + chatID.ToString() + "*" + txtChat.Text + "*" + time);
            sw.Close();
            txtChat.Text = "";
        }

        private void emojiBtn_Click(object sender, EventArgs e)
        {
            if (!emojiClick)
            {
                emojiClick = true;
                emoPanel.BringToFront();
            }else
            {
                emojiClick = false;
                emoPanel.SendToBack();
            }
        }

        void sendEmo(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            PictureBox a = (PictureBox)sender;
            string s = a.ImageLocation;
            SendEmo(s, time);
            string pathDataChat = "C:\\university\\cs511\\chatapp\\data\\history\\" + "chat" + "from" + currentID + "to" + chatID + ".txt";
            StreamWriter sw = new StreamWriter(pathDataChat, true);
            sw.WriteLine("emo*" + currentID.ToString() + "*" + chatID.ToString() + "*" + a.ImageLocation + "*" + time);
            sw.Close();
        }

        private void imgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Multiselect = true;
            f.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            string time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            if (f.ShowDialog() == DialogResult.OK)
            {
                string txtFile = "";
                for (int i = 0; i < f.FileNames.Length; i++)
                {
                    if(i == 0)
                    {
                        txtFile += f.FileNames[i];
                    }else
                    {
                        txtFile += "&" + f.FileNames[i];
                    }
                    PictureBox a = new PictureBox();
                    a.Image = Image.FromFile(f.FileNames[i]);
                    a.SizeMode = PictureBoxSizeMode.Zoom;
                    a.Size = new Size(150, 150);
                    a.Click += new EventHandler(previewImage);
                    pnImages.Controls.Add(a);
                }
                SendImage(f.FileNames, time);
                string pathDataChat = "C:\\university\\cs511\\chatapp\\data\\history\\" + "chat" + "from" + currentID + "to" + chatID + ".txt";
                StreamWriter sw = new StreamWriter(pathDataChat, true);
                sw.WriteLine("image*" + currentID.ToString() + "*" + chatID.ToString() + "*" + txtFile + "*" + time);
                sw.Close();
            }
        }


        private void videoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Multiselect = true;
            f.Filter = "Video Files (*.mp4, *.avi, *.mkv)|*.mp4;*.avi;*.mkv|All files (*.*)|*.*";
            string time = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            if (f.ShowDialog() == DialogResult.OK)
            {
                string txtFile = "";
                for(int i = 0; i < f.FileNames.Length; i++)
                {
                    if (i == 0)
                    {
                        txtFile += f.FileNames[i];
                    }
                    else
                    {
                        txtFile += "&" + f.FileNames[i];
                    }
                    video a = new video();
                    a.content(f.FileNames[i]);
                    pnVideos.Controls.Add(a);
                }
                SendVideo(f.FileNames, time);
                string pathDataChat = "C:\\university\\cs511\\chatapp\\data\\history\\" + "chat" + "from" + currentID + "to" + chatID + ".txt";
                StreamWriter sw = new StreamWriter(pathDataChat, true);
                sw.WriteLine("video*" + currentID.ToString() + "*" + chatID.ToString() + "*" + txtFile + "*" + time);
                sw.Close();
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        void Search()
        {
            string keyword = searchBox.Text;
            foreach (Control control in pnContents.Controls)
            {
                if (control is userText)
                {
                    userText userTextBox = (userText)control;
                    bool find = userTextBox.selectText(keyword);
                    if (!find)
                    {
                        MessageBox.Show("Không tìm thấy từ cần tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public void previewImage(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            preview previewForm = new preview(pictureBox.Image);
            previewForm.ShowDialog();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void galleryBtn_Click(object sender, EventArgs e)
        {

            panelGallery.BringToFront();
            panelGallery.Visible = true;
            pnSettings.Visible = false;
            pnContent.Visible = false;
            pnSettings.SendToBack();
            pnContent.SendToBack();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            pnContent.BringToFront();
            pnContent.Visible = true;
            panelGallery.Visible=false;
            pnSettings.Visible=false;
            panelGallery.SendToBack();
            pnSettings.SendToBack();
        }

        private void extensionsBtn_Click(object sender, EventArgs e)
        {

            pnSettings.BringToFront();
            pnSettings.Visible = true;
            panelGallery.Visible = false;
            pnContent.Visible = false;
            panelGallery.SendToBack();
            pnContent.SendToBack();
        }

        void resetUserPanelLanguage()
        {
            if (stateLanguge == 1)
            {
                
                stateLanguge = 1;
                lblSettings.Text = "Setting";
                lblLightDark.Text = "Light/Dark: ";
                languageLbl.Text = "Language: ";
                if (usrText.Text == "Không hoạt động")
                {
                    usrText.Text = "Offline";
                }
                else
                {
                    usrText.Text = "Online";
                }

                if (messText.Text == "Không hoạt động")
                {
                    messText.Text = "Offline";
                }
                else
                {
                    messText.Text = "Online";
                }

                galleryLbl.Text = "Gallery";
                imgLbl.Text = "Images: ";
                vietnamese.Text = "Vietnamese";
                english.Text = "English";
                dark.Text = "Dark";
                light.Text = "Light";

            }
            else if (stateLanguge== 0)
            {


                stateLanguge = 0;
                lblSettings.Text = "Cài đặt";
                lblLightDark.Text = "Sáng/Tối: ";
                languageLbl.Text = "Ngôn ngữ: ";
                if (usrText.Text == "Online")
                {
                    usrText.Text = "Đang hoạt động";
                }
                else
                {
                    usrText.Text = "Không hoạt động";
                }
                if (messText.Text == "Online")
                {
                    messText.Text = "Đang hoạt động";
                }
                else
                {
                    messText.Text = "Không hoạt động";
                }
                galleryLbl.Text = "Thư viện";
                imgLbl.Text = "Hình ảnh: ";
                vietnamese.Text = "Tiếng Việt";
                english.Text = "Tiếng Anh";
                dark.Text = "Tối";
                light.Text = "Sáng";
            }
            pnUsers.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                int id = (int)row["ID"];
                string avatarPath = (string)row["AvatarPath"];
                string status = (string)row["Status"];
                string email = (string)row["Email"];
                string pass = (string)row["Password"];
                string name = (string)row["Name"];
                if (id != currentID)
                {
                    userInfo usr = new userInfo();
                    usr.content(id, avatarPath, name, status, stateBrightness, stateLanguge);
                    pnUsers.Controls.Add(usr);
                    usr.Click += new EventHandler(UserClick);
                    messAva.Image = Image.FromFile(avatarPath);
                    messName.Text = name;
                    if (status == "off")
                    {
                        messStatus.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\offline.png");
                        if(stateLanguge == 0)
                        {
                            messText.Text = "Không hoạt động";
                        }
                        else
                        {
                            messText.Text = "Offline";
                        }
                    }
                    else
                    {
                        messStatus.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\online.png");
                        if (stateLanguge == 0)
                        {
                            messText.Text = "Đang hoạt động";
                        }
                        else
                        {
                            messText.Text = "Online";
                        }
                    }
                }

            }
        }

        void resetUserPanelBrightness()
        {
            if (stateBrightness == 1)
            {
                stateBrightness = 1;
                // settings change
                pnSettings.BackColor = Color.FromArgb(10, 30, 52);
                pnUsers.BackColor = Color.FromArgb(12, 28, 46);
                pnExtensions.BackColor = Color.FromArgb(5, 18, 33);
                pnInfo.BackColor = Color.FromArgb(4, 13, 23);
                lblSettings.ForeColor = Color.White;
                lblLightDark.ForeColor = Color.White;
                languageLbl.ForeColor = Color.White;

                // user list change
                usrName.ForeColor = Color.White;
                usrText.ForeColor = Color.White;
                homeBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\home-light.png");
                galleryBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\gallery-light.png");
                extensionsBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\extention-light.png");

                // gallery change
                galleryLbl.ForeColor = Color.White;
                imgLbl.ForeColor = Color.White;
                videoLbl.ForeColor = Color.White;
                panelGallery.BackColor = Color.FromArgb(10, 30, 52);

                // content change
                imgBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\image-light.png");
                videoBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\video-light.png");
                emojiBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\emoji-light.png");
                sendBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\send-light.png");
                logoutBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\out-light.png");
                imgBtn.BackColor = Color.FromArgb(10, 30, 52);
                videoBtn.BackColor = Color.FromArgb(10, 30, 52);
                emojiBtn.BackColor = Color.FromArgb(10, 30, 52);
                sendBtn.BackColor = Color.FromArgb(10, 30, 52);
                emoPanel.FillColor = Color.FromArgb(10, 30, 52);
                pnContents.BackColor = Color.FromArgb(10, 30, 52);
                pnMessage.FillColor = Color.FromArgb(10, 30, 52);
                txtChat.BackColor = Color.FromArgb(10, 30, 52);
                searchBox.BackColor = Color.FromArgb(10, 30, 52);
                messName.ForeColor = Color.White;
                messText.ForeColor = Color.White;
                pnContent.BackColor = Color.FromArgb(10, 30, 52);
                searchBtn.BackColor = Color.White;
                vietnamese.ForeColor = Color.White;
                english.ForeColor = Color.White;
                dark.ForeColor = Color.White;
                light.ForeColor = Color.White;
            }
            else if (stateBrightness == 0)
            {
                stateBrightness = 0;
                // settings change
                pnSettings.BackColor = Color.White;
                pnUsers.BackColor = Color.FromArgb(245, 250, 255);
                pnExtensions.BackColor = Color.FromArgb(226, 243, 255);
                pnInfo.BackColor = Color.FromArgb(177, 222, 255);
                lblSettings.ForeColor = Color.FromArgb(49, 141, 221);
                lblLightDark.ForeColor = Color.FromArgb(49, 141, 221);
                languageLbl.ForeColor = Color.FromArgb(49, 141, 221);

                // user list change
                usrName.ForeColor = Color.Black;
                usrText.ForeColor = Color.Black;
                homeBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\home.png");
                galleryBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\gallery.png");
                extensionsBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\menu.png");

                // gallery change
                galleryLbl.ForeColor = Color.FromArgb(49, 141, 221);
                imgLbl.ForeColor = Color.FromArgb(49, 141, 221);
                videoLbl.ForeColor = Color.FromArgb(49, 141, 221);
                panelGallery.BackColor = Color.White;

                // content change
                imgBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\image-add.png");
                videoBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\video-add1.png");
                emojiBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\emoji.png");
                sendBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\send.png");
                logoutBtn.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\out.png");
                imgBtn.BackColor = Color.White;
                videoBtn.BackColor = Color.White;
                emojiBtn.BackColor = Color.White;
                sendBtn.BackColor = Color.White;
                emoPanel.FillColor = Color.White;
                pnContents.BackColor = Color.White;
                pnMessage.FillColor = Color.White;
                txtChat.BackColor = Color.White;
                searchBox.BackColor = Color.White;
                messName.ForeColor = Color.Black;
                messText.ForeColor = Color.Black;
                pnContent.BackColor = Color.White;
                vietnamese.ForeColor = Color.Black;
                english.ForeColor = Color.Black;
                dark.ForeColor = Color.Black;
                light.ForeColor = Color.Black;

            }
            pnUsers.Controls.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                int id = (int)row["ID"];
                string avatarPath = (string)row["AvatarPath"];
                string status = (string)row["Status"];
                string email = (string)row["Email"];
                string pass = (string)row["Password"];
                string name = (string)row["Name"];
                if (id != currentID)
                {
                    Console.WriteLine(id);

                    userInfo usr = new userInfo();
                    usr.content(id, avatarPath, name, status, stateBrightness, stateLanguge);
                    pnUsers.Controls.Add(usr);
                    usr.Click += new EventHandler(UserClick);
                    chatID = id;
                    messAva.Image = Image.FromFile(avatarPath);
                    messName.Text = name;
                    restorePanel(currentID, chatID);

                    if (status == "off")
                    {
                        messStatus.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\offline.png");
                        messText.Text = "Không hoạt động";
                    }
                    else
                    {
                        messStatus.BackgroundImage = Image.FromFile("C:\\Users\\hang\\source\\repos\\TH1\\ChatApp\\ChatApp\\Resources\\online.png");
                        messText.Text = "Đang hoạt động";
                    }
                }

            }
        }


        private void lightDarkBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }


        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormSignIn formSignIn = new FormSignIn(stateLanguge);
            formSignIn.Show();
            this.Hide();
        }

        private void light_CheckedChanged(object sender, EventArgs e)
        {
            if (light.Checked)
            {
                dark.Checked = false;
                stateBrightness = 0;
                resetUserPanelBrightness();
            }

        }

        private void dark_CheckedChanged(object sender, EventArgs e)
        {
            if (dark.Checked)
            {
                light.Checked = false;
                stateBrightness = 1;
                resetUserPanelBrightness();
            }    
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (vietnamese.Checked)
            {
                stateLanguge = 0;
                resetUserPanelLanguage();
                english.Checked = false;
            }    

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (english.Checked)
            {
                stateLanguge = 1;
                resetUserPanelLanguage();
                vietnamese.Checked = false;
            }else
            {
            }    
        }
    }
}
