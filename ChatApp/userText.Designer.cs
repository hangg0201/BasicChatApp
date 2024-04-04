namespace ChatApp
{
    partial class userText
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
            this.messBox = new System.Windows.Forms.RichTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.ava = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ava)).BeginInit();
            this.SuspendLayout();
            // 
            // messBox
            // 
            this.messBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.messBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.messBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messBox.ForeColor = System.Drawing.Color.White;
            this.messBox.Location = new System.Drawing.Point(69, 18);
            this.messBox.Name = "messBox";
            this.messBox.ReadOnly = true;
            this.messBox.Size = new System.Drawing.Size(312, 44);
            this.messBox.TabIndex = 30;
            this.messBox.Text = "";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(311, 73);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 19);
            this.lblTime.TabIndex = 29;
            this.lblTime.Text = "label1";
            // 
            // ava
            // 
            this.ava.BackgroundImage = global::ChatApp.Properties.Resources.st;
            this.ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ava.Image = global::ChatApp.Properties.Resources.st;
            this.ava.Location = new System.Drawing.Point(12, 18);
            this.ava.Margin = new System.Windows.Forms.Padding(2);
            this.ava.Name = "ava";
            this.ava.Size = new System.Drawing.Size(42, 42);
            this.ava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava.TabIndex = 28;
            this.ava.TabStop = false;
            // 
            // userText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.messBox);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.ava);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "userText";
            this.Size = new System.Drawing.Size(401, 102);
            ((System.ComponentModel.ISupportInitialize)(this.ava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox messBox;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox ava;
    }
}
