namespace ChatApp
{
    partial class userInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.ava = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.statusImg = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(95, 14);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 21);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.Black;
            this.text.Location = new System.Drawing.Point(125, 41);
            this.text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(48, 20);
            this.text.TabIndex = 3;
            this.text.Text = "label2";
            // 
            // ava
            // 
            this.ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ava.Image = global::ChatApp.Properties.Resources.st;
            this.ava.Location = new System.Drawing.Point(13, 10);
            this.ava.Margin = new System.Windows.Forms.Padding(2);
            this.ava.Name = "ava";
            this.ava.Size = new System.Drawing.Size(52, 52);
            this.ava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava.TabIndex = 5;
            this.ava.TabStop = false;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(366, 25);
            this.guna2CirclePictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(43, 42);
            this.guna2CirclePictureBox2.TabIndex = 4;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // statusImg
            // 
            this.statusImg.BackgroundImage = global::ChatApp.Properties.Resources.online;
            this.statusImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.statusImg.Location = new System.Drawing.Point(99, 33);
            this.statusImg.Margin = new System.Windows.Forms.Padding(2);
            this.statusImg.Name = "statusImg";
            this.statusImg.Size = new System.Drawing.Size(14, 32);
            this.statusImg.TabIndex = 2;
            this.statusImg.TabStop = false;
            // 
            // userInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ava);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.text);
            this.Controls.Add(this.statusImg);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "userInfo";
            this.Size = new System.Drawing.Size(355, 72);
            ((System.ComponentModel.ISupportInitialize)(this.ava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox statusImg;
        private System.Windows.Forms.Label text;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.PictureBox ava;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
