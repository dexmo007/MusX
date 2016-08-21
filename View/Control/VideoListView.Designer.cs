namespace MusX_v02.View.Control
{
    partial class VideoListView
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
            this.youtubeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // youtubeListBox
            // 
            this.youtubeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.youtubeListBox.FormattingEnabled = true;
            this.youtubeListBox.ItemHeight = 16;
            this.youtubeListBox.Location = new System.Drawing.Point(0, 0);
            this.youtubeListBox.Margin = new System.Windows.Forms.Padding(4);
            this.youtubeListBox.Name = "youtubeListBox";
            this.youtubeListBox.Size = new System.Drawing.Size(773, 540);
            this.youtubeListBox.TabIndex = 5;
            this.youtubeListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.youtubeListBox_MouseDoubleClick);
            // 
            // VideoListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.youtubeListBox);
            this.Name = "VideoListView";
            this.Size = new System.Drawing.Size(773, 540);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox youtubeListBox;
    }
}
