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

namespace ChatApp
{
    public partial class FormSignUp : Form
    {
        string PathImageTo = "";
        string pathUser = "";
        string PathImageFrom = "";
        int ID = -1;
        int state = 0;

        public FormSignUp()
        {
            InitializeComponent();
        }

        public FormSignUp(int stateLanguage)
        {
            InitializeComponent();
            state = stateLanguage;
            if(state == 0)
            {
                header.Text = "Đăng ký";
                signUpBtn.Text = "Đăng ký";
                label1.Text = "Họ và tên";
                label2.Text = "Mật khẩu";
                label3.Text = "Ảnh đại diện";
                signinLbl.Text = "Bạn đã có tài khoản?";
            }
            else if(state == 1)
            {
                header.Text = "Sign up";
                signUpBtn.Text = "Sign up";
                label1.Text = "Name";
                label2.Text = "Password";
                label3.Text = "Avater";
                signinLbl.Text = "Have you had account?";
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PathImageFrom = openFileDialog.FileName;
                txtImage.Text = PathImageFrom;
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            bool haveEmail = false;
            using (StreamReader reader = new StreamReader(pathUser))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('*');
                    if(parts.Length < 5)
                    {
                        continue;
                    }
                    string email = parts[3];
                    if (email == txtEmail.Text)
                    {
                        haveEmail = true;

                        break;
                    }
                }
            }

            bool errorSignUp = false;

            if (txtImage.Text == "")
            {
                errorImage.Visible = true;
                if (state == 1)
                {
                    errorEmail.Text = "Please do not leave it blank";
                }
                else
                {
                    errorEmail.Text = "Vui lòng không để trống!";
                }
                errorSignUp = true; 
            }else
            {
                errorImage.Visible = false;
            }

            if (txtName.Text == "")
            {
                errorName.Visible= true;
                if (state == 1)
                {
                    errorEmail.Text = "Please do not leave it blank";
                }
                else
                {
                    errorEmail.Text = "Vui lòng không để trống!";
                }
                errorSignUp = true;
            }
            else
            {
                errorName.Visible = false;
            }
            if (txtPass.Text == "")
            {
                errorPass.Visible = true;
                if (state == 1)
                {
                    errorEmail.Text = "Please do not leave it blank";
                }
                else
                {
                    errorEmail.Text = "Vui lòng không để trống!";
                }
                errorSignUp = true;
            }
            else
            {
                errorPass.Visible = false;
            }

            if (txtEmail.Text == "")
            {
                errorEmail.Visible = true;
                if (state == 1)
                {
                    errorEmail.Text = "Please do not leave it blank";
                }else
                {
                    errorEmail.Text = "Vui lòng không để trống!";
                }
                errorSignUp = true;
            }
            else if (haveEmail)
            {
                errorEmail.Visible = true;
                errorEmail.Text = "Email đã tồn tại, thử lại!";
                if (state == 1)
                {
                    errorEmail.Text = "Email already exists, try again!";
                }
                else
                {
                    errorEmail.Text = "Email đã tồn tại, thử lại!";
                }
                errorSignUp = true;
            }
            else
            {
                errorEmail.Visible = false;
            }

            if (haveEmail) return;

            try
            {
                PathImageTo = "C:\\university\\cs511\\chatapp\\data\\ava\\" + "ava" + ID + ".jpg";
                pathUser = "C:\\university\\cs511\\chatapp\\data\\user\\" + "user.txt";
                
                StreamWriter sw = new StreamWriter(pathUser, true);
                sw.WriteLine(ID.ToString() + "*" + PathImageTo + "*off*" + txtEmail.Text + "*" +  txtPass.Text + "*" + txtName.Text);
                sw.Close();

                FileInfo fi = new FileInfo(PathImageFrom);
                fi.CopyTo(PathImageTo);
                if(state == 1)
                {
                    MessageBox.Show("Account registration successful!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }else
                {
                    MessageBox.Show("Đăng ký  tài khoản thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtEmail.Text = "";
                txtPass.Text = "";
                txtName.Text = "";
                txtImage.Text = "";
                ID++;
            }
            catch
            {
                if (state == 1)
                {
                    MessageBox.Show("Account registration failed!!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            errorEmail.Visible = false;
            errorImage.Visible = false;
            errorName.Visible = false;
            errorPass.Visible = false;
            pathUser = "C:\\university\\cs511\\chatapp\\data\\user\\" + "user.txt";
            using (StreamReader reader = new StreamReader(pathUser))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {         
                    string[] parts = line.Split('*');
                    if (parts.Length < 5)
                    {
                        continue;
                    }
                    ID = int.Parse(parts[0]);
                }
            }
            ID += 1;
        }

        private void signinLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignIn formSignIn = new FormSignIn(state);
            formSignIn.Show();
            this.Hide();
        }
    }
}
