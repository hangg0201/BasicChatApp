namespace ChatApp
{
    partial class preview
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
            this.pnPreview = new System.Windows.Forms.Panel();
            this.imageShow = new System.Windows.Forms.PictureBox();
            this.pnPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageShow)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPreview
            // 
            this.pnPreview.Controls.Add(this.imageShow);
            this.pnPreview.Location = new System.Drawing.Point(0, 0);
            this.pnPreview.Name = "pnPreview";
            this.pnPreview.Size = new System.Drawing.Size(926, 482);
            this.pnPreview.TabIndex = 0;
            // 
            // imageShow
            // 
            this.imageShow.BackgroundImage = global::ChatApp.Properties.Resources.emo10;
            this.imageShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageShow.Location = new System.Drawing.Point(3, 3);
            this.imageShow.Name = "imageShow";
            this.imageShow.Size = new System.Drawing.Size(923, 489);
            this.imageShow.TabIndex = 0;
            this.imageShow.TabStop = false;
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(926, 490);
            this.Controls.Add(this.pnPreview);
            this.Name = "preview";
            this.Text = "preview";
            this.pnPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPreview;
        private System.Windows.Forms.PictureBox imageShow;
    }
}