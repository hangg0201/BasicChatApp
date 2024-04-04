namespace ChatApp
{
    partial class userImage
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
            this.lblTime = new System.Windows.Forms.Label();
            this.ava = new System.Windows.Forms.PictureBox();
            this.pnImages = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ava)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(253, 252);
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
            this.ava.Location = new System.Drawing.Point(13, 13);
            this.ava.Margin = new System.Windows.Forms.Padding(2);
            this.ava.Name = "ava";
            this.ava.Size = new System.Drawing.Size(42, 42);
            this.ava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava.TabIndex = 27;
            this.ava.TabStop = false;
            // 
            // pnImages
            // 
            this.pnImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnImages.Location = new System.Drawing.Point(82, 13);
            this.pnImages.Name = "pnImages";
            this.pnImages.Size = new System.Drawing.Size(216, 226);
            this.pnImages.TabIndex = 31;
            // 
            // userImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnImages);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.ava);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "userImage";
            this.Size = new System.Drawing.Size(327, 280);
            ((System.ComponentModel.ISupportInitialize)(this.ava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox ava;
        private System.Windows.Forms.FlowLayoutPanel pnImages;
    }
}
