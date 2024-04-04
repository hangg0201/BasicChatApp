namespace ChatApp
{
    partial class userVideo
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
            this.pnVideos = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ava)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(528, 199);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 28);
            this.lblTime.TabIndex = 32;
            this.lblTime.Text = "label1";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // ava
            // 
            this.ava.BackgroundImage = global::ChatApp.Properties.Resources.st;
            this.ava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ava.Image = global::ChatApp.Properties.Resources.st;
            this.ava.Location = new System.Drawing.Point(20, 20);
            this.ava.Name = "ava";
            this.ava.Size = new System.Drawing.Size(63, 65);
            this.ava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava.TabIndex = 31;
            this.ava.TabStop = false;
            // 
            // pnVideos
            // 
            this.pnVideos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnVideos.Location = new System.Drawing.Point(117, 20);
            this.pnVideos.Name = "pnVideos";
            this.pnVideos.Size = new System.Drawing.Size(635, 164);
            this.pnVideos.TabIndex = 33;
            // 
            // userVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnVideos);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.ava);
            this.Name = "userVideo";
            this.Size = new System.Drawing.Size(795, 244);
            ((System.ComponentModel.ISupportInitialize)(this.ava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox ava;
        private System.Windows.Forms.FlowLayoutPanel pnVideos;
    }
}
