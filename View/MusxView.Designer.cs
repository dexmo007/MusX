namespace MusX_v02.View
{
    partial class MusxView
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageYouTube = new System.Windows.Forms.TabPage();
            this.videoListView1 = new MusX_v02.View.Control.VideoListView();
            this.spotifyTabPage = new System.Windows.Forms.TabPage();
            this.trackListView1 = new MusX_v02.View.Control.TrackListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageYouTube.SuspendLayout();
            this.spotifyTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(17, 16);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(385, 22);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(412, 12);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1371, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 20);
            this.statusLabel.Text = "StatusReady";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageYouTube);
            this.tabControl.Controls.Add(this.spotifyTabPage);
            this.tabControl.Location = new System.Drawing.Point(17, 49);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1341, 478);
            this.tabControl.TabIndex = 5;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageYouTube
            // 
            this.tabPageYouTube.Controls.Add(this.videoListView1);
            this.tabPageYouTube.Location = new System.Drawing.Point(4, 25);
            this.tabPageYouTube.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageYouTube.Name = "tabPageYouTube";
            this.tabPageYouTube.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageYouTube.Size = new System.Drawing.Size(1333, 449);
            this.tabPageYouTube.TabIndex = 0;
            this.tabPageYouTube.Text = "YouTube";
            this.tabPageYouTube.UseVisualStyleBackColor = true;
            // 
            // videoListView1
            // 
            this.videoListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoListView1.Location = new System.Drawing.Point(4, 4);
            this.videoListView1.Name = "videoListView1";
            this.videoListView1.Size = new System.Drawing.Size(1325, 441);
            this.videoListView1.TabIndex = 0;
            // 
            // spotifyTabPage
            // 
            this.spotifyTabPage.Controls.Add(this.trackListView1);
            this.spotifyTabPage.Controls.Add(this.listView1);
            this.spotifyTabPage.Location = new System.Drawing.Point(4, 25);
            this.spotifyTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.spotifyTabPage.Name = "spotifyTabPage";
            this.spotifyTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.spotifyTabPage.Size = new System.Drawing.Size(1333, 449);
            this.spotifyTabPage.TabIndex = 2;
            this.spotifyTabPage.Text = "Spotify";
            this.spotifyTabPage.UseVisualStyleBackColor = true;
            // 
            // trackListView1
            // 
            this.trackListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackListView1.Location = new System.Drawing.Point(4, 4);
            this.trackListView1.Margin = new System.Windows.Forms.Padding(4);
            this.trackListView1.Name = "trackListView1";
            this.trackListView1.Size = new System.Drawing.Size(1325, 441);
            this.trackListView1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1325, 441);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MusxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 556);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusxView";
            this.Text = "MusX";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageYouTube.ResumeLayout(false);
            this.spotifyTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageYouTube;
        private System.Windows.Forms.TabPage spotifyTabPage;
        private System.Windows.Forms.ListView listView1;
        private Control.TrackListView trackListView1;
        private Control.VideoListView videoListView1;
    }
}