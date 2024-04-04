namespace ChatApp
{
    partial class video
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(video));
            this.playerVideo = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.playerVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // playerVideo
            // 
            this.playerVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerVideo.Enabled = true;
            this.playerVideo.Location = new System.Drawing.Point(0, 0);
            this.playerVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playerVideo.Name = "playerVideo";
            this.playerVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerVideo.OcxState")));
            this.playerVideo.Size = new System.Drawing.Size(300, 200);
            this.playerVideo.TabIndex = 0;
            this.playerVideo.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.playerVideo_ClickEvent);
            // 
            // video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.playerVideo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "video";
            this.Size = new System.Drawing.Size(300, 200);
            ((System.ComponentModel.ISupportInitialize)(this.playerVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer playerVideo;
    }
}
