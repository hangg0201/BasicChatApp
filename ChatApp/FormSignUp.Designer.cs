namespace ChatApp
{
    partial class FormSignUp
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
            System.Windows.Forms.PictureBox emailPic;
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.PictureBox pictureBox3;
            this.header = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtImage = new Guna.UI2.WinForms.Guna2TextBox();
            this.signUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.uploadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.errorEmail = new System.Windows.Forms.Label();
            this.errorName = new System.Windows.Forms.Label();
            this.errorPass = new System.Windows.Forms.Label();
            this.errorImage = new System.Windows.Forms.Label();
            this.signinLbl = new System.Windows.Forms.LinkLabel();
            emailPic = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(emailPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // emailPic
            // 
            emailPic.BackgroundImage = global::ChatApp.Properties.Resources.mail;
            emailPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            emailPic.Location = new System.Drawing.Point(88, 144);
            emailPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            emailPic.Name = "emailPic";
            emailPic.Size = new System.Drawing.Size(57, 46);
            emailPic.TabIndex = 2;
            emailPic.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = global::ChatApp.Properties.Resources.user;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Location = new System.Drawing.Point(88, 235);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(57, 46);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = global::ChatApp.Properties.Resources.key;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Location = new System.Drawing.Point(88, 319);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(57, 46);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = global::ChatApp.Properties.Resources.gallery;
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox3.Location = new System.Drawing.Point(88, 410);
            pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(57, 46);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.Firebrick;
            this.header.Location = new System.Drawing.Point(234, 41);
            this.header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(208, 55);
            this.header.TabIndex = 0;
            this.header.Text = "Đăng ký";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.IconRightSize = new System.Drawing.Size(0, 0);
            this.txtEmail.Location = new System.Drawing.Point(157, 144);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.BorderRadius = 3;
            this.txtEmail.Size = new System.Drawing.Size(399, 41);
            this.txtEmail.TabIndex = 1;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.emailLbl.Location = new System.Drawing.Point(87, 113);
            this.emailLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(52, 20);
            this.emailLbl.TabIndex = 3;
            this.emailLbl.Text = "Email:";
            this.emailLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(87, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Họ và tên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.txtName.BorderRadius = 15;
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.IconRightSize = new System.Drawing.Size(0, 0);
            this.txtName.Location = new System.Drawing.Point(157, 235);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.BorderRadius = 3;
            this.txtName.Size = new System.Drawing.Size(399, 46);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(87, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.txtPass.BorderRadius = 15;
            this.txtPass.BorderThickness = 2;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.IconRightSize = new System.Drawing.Size(0, 0);
            this.txtPass.Location = new System.Drawing.Point(157, 319);
            this.txtPass.Margin = new System.Windows.Forms.Padding(0);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPass.PlaceholderText = "";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.BorderRadius = 3;
            this.txtPass.Size = new System.Drawing.Size(399, 46);
            this.txtPass.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(87, 378);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ảnh đại diện";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.txtImage.BorderRadius = 15;
            this.txtImage.BorderThickness = 2;
            this.txtImage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImage.DefaultText = "";
            this.txtImage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.ForeColor = System.Drawing.Color.Black;
            this.txtImage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImage.IconRightSize = new System.Drawing.Size(0, 0);
            this.txtImage.Location = new System.Drawing.Point(157, 410);
            this.txtImage.Margin = new System.Windows.Forms.Padding(0);
            this.txtImage.Name = "txtImage";
            this.txtImage.PasswordChar = '\0';
            this.txtImage.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtImage.PlaceholderText = "";
            this.txtImage.ReadOnly = true;
            this.txtImage.SelectedText = "";
            this.txtImage.ShadowDecoration.BorderRadius = 3;
            this.txtImage.Size = new System.Drawing.Size(271, 46);
            this.txtImage.TabIndex = 10;
            // 
            // signUpBtn
            // 
            this.signUpBtn.BorderRadius = 15;
            this.signUpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUpBtn.FillColor = System.Drawing.Color.Firebrick;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.ForeColor = System.Drawing.Color.White;
            this.signUpBtn.Location = new System.Drawing.Point(212, 508);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(244, 45);
            this.signUpBtn.TabIndex = 13;
            this.signUpBtn.Text = "Đăng ký";
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.IndianRed;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(575, 34);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(25, 25);
            this.guna2CircleButton1.TabIndex = 14;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.IndianRed;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Location = new System.Drawing.Point(619, -14);
            this.guna2CircleButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(59, 53);
            this.guna2CircleButton2.TabIndex = 15;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.FillColor = System.Drawing.Color.IndianRed;
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.Location = new System.Drawing.Point(-125, 522);
            this.guna2CircleButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.Size = new System.Drawing.Size(265, 195);
            this.guna2CircleButton3.TabIndex = 16;
            // 
            // uploadBtn
            // 
            this.uploadBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.uploadBtn.BorderRadius = 15;
            this.uploadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.uploadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.uploadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.uploadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.uploadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.uploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.ForeColor = System.Drawing.Color.White;
            this.uploadBtn.Location = new System.Drawing.Point(451, 410);
            this.uploadBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(106, 45);
            this.uploadBtn.TabIndex = 17;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // errorEmail
            // 
            this.errorEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorEmail.AutoSize = true;
            this.errorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEmail.ForeColor = System.Drawing.Color.Red;
            this.errorEmail.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errorEmail.Location = new System.Drawing.Point(392, 203);
            this.errorEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(166, 18);
            this.errorEmail.TabIndex = 18;
            this.errorEmail.Text = "Vui lòng không để trống!";
            this.errorEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorName
            // 
            this.errorName.AutoSize = true;
            this.errorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorName.ForeColor = System.Drawing.Color.Red;
            this.errorName.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errorName.Location = new System.Drawing.Point(392, 290);
            this.errorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorName.Name = "errorName";
            this.errorName.Size = new System.Drawing.Size(166, 18);
            this.errorName.TabIndex = 19;
            this.errorName.Text = "Vui lòng không để trống!";
            this.errorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorPass
            // 
            this.errorPass.AutoSize = true;
            this.errorPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPass.ForeColor = System.Drawing.Color.Red;
            this.errorPass.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errorPass.Location = new System.Drawing.Point(392, 377);
            this.errorPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorPass.Name = "errorPass";
            this.errorPass.Size = new System.Drawing.Size(166, 18);
            this.errorPass.TabIndex = 20;
            this.errorPass.Text = "Vui lòng không để trống!";
            this.errorPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorImage
            // 
            this.errorImage.AutoSize = true;
            this.errorImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorImage.ForeColor = System.Drawing.Color.Red;
            this.errorImage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.errorImage.Location = new System.Drawing.Point(392, 470);
            this.errorImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.errorImage.Name = "errorImage";
            this.errorImage.Size = new System.Drawing.Size(166, 18);
            this.errorImage.TabIndex = 21;
            this.errorImage.Text = "Vui lòng không để trống!";
            this.errorImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signinLbl
            // 
            this.signinLbl.AutoSize = true;
            this.signinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinLbl.LinkColor = System.Drawing.Color.Black;
            this.signinLbl.Location = new System.Drawing.Point(259, 569);
            this.signinLbl.Name = "signinLbl";
            this.signinLbl.Size = new System.Drawing.Size(147, 18);
            this.signinLbl.TabIndex = 23;
            this.signinLbl.TabStop = true;
            this.signinLbl.Text = "Bạn đã có tài khoản?";
            this.signinLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signinLbl_LinkClicked);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 614);
            this.Controls.Add(this.signinLbl);
            this.Controls.Add(this.errorImage);
            this.Controls.Add(this.errorPass);
            this.Controls.Add(this.errorName);
            this.Controls.Add(this.errorEmail);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.guna2CircleButton3);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(emailPic);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.header);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(emailPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtImage;
        private Guna.UI2.WinForms.Guna2Button signUpBtn;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2Button uploadBtn;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.Label errorName;
        private System.Windows.Forms.Label errorPass;
        private System.Windows.Forms.Label errorImage;
        private System.Windows.Forms.LinkLabel signinLbl;
    }
}