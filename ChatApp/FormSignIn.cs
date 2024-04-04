using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp
{
    public partial class FormSignIn : Form
    {
        int state = 0;
        public FormSignIn()
        {
            InitializeComponent();
            
        }

        public FormSignIn(int stateLanguage)
        {
            InitializeComponent();
            state = stateLanguage;
            if (stateLanguage == 0 )
            {
                txtContent.Text = "Quên mật khẩu";
                resetPassBtn.Text = "Khôi phục mật khẩu";
                backSignIn.Text = "Quay lại trang đăng nhập";
                linkLabel1.Text = "ĐĂNG KÝ";
                header.Text = "Đăng nhập";
                label2.Text = "Mật khẩu";
                forgetPass.Text = "Quên mật khẩu?";
                linkSignUp.Text = "ĐĂNG KÝ";
                signInBtn.Text = "Đăng nhập";
            }
            else
            {
                txtContent.Text = "Forget password";
                resetPassBtn.Text = "Reset password";
                backSignIn.Text = "Back to sign in form";
                linkLabel1.Text = "SIGN UP";
                header.Text = "Sign in";
                label2.Text = "Password";
                forgetPass.Text = "Forget password?";
                linkSignUp.Text = "SIGN UP";
                signInBtn.Text = "Sign in";
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            string pathUser = "C:\\university\\cs511\\chatapp\\data\\user\\" + "user.txt";
            bool validAccount = false;
            string validEmail = "";
            using (StreamReader reader = new StreamReader(pathUser))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('*');
                    string email = parts[3];
                    string pass = parts[4];
                    if (email == txtEmail.Text && pass == txtPass.Text)
                    {
                        validAccount = true;
                        validEmail = email;
                        break;
                    }

                }
            }
            if (validAccount)
            {
                MessageBox.Show("Đăng nhập  tài khoản thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormChat formChat = new FormChat(validEmail, state);
                formChat.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng, vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp(state);
            formSignUp.Show();
            this.Hide();
        }

        private void forgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnForgot.Visible = true;
        }

        private void backSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnForgot.Visible = false;
        }

        private void resetPassBtn_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress(".....@gmail.com");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(".....@gmail.com", "....");
            smtp.Host = "smtp.gmail.com";

            //recipient
            mail.To.Add(new MailAddress(txtEmailForgot.Text));
            mail.IsBodyHtml = true;
            mail.Subject = "Khôi phục mật khẩu";
            mail.Body = "Mật khẩu của bạn là: 12345";

            //for (int i = 0; i < attachmentFilename.Length; i++)
            //    mail.Attachments.Add(new Attachment(attachmentFilename[i]));

            smtp.Send(mail);
            string pathUser = "C:\\university\\cs511\\chatapp\\data\\user\\" + "user.txt"; string tempFile = Path.GetTempFileName();

            bool emailFound = false;

            using (StreamReader reader = new StreamReader(pathUser))
            using (StreamWriter writer = new StreamWriter(tempFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('*');
                    string email = parts[3];
                    string pass = parts[4];

                    if (email == txtEmailForgot.Text)
                    {
                        pass = "12345"; // Đổi mật khẩu thành "12345"
                        emailFound = true;
                    }

                    // Ghi lại dòng đã chỉnh sửa hoặc không
                    writer.WriteLine($"{parts[0]}*{parts[1]}*{parts[2]}*{email}*{pass}*{parts[5]}");
                }
            }

            // Thay thế tệp gốc bằng tệp đã chỉnh sửa
            File.Delete(pathUser);
            File.Move(tempFile, pathUser);

            if (emailFound)
            {
                MessageBox.Show("Password reset successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
