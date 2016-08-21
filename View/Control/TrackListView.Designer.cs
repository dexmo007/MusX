using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MusX_v02.View.Control
{
    partial class TrackListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            this.dataGridView1 = new DataGridView();
            this.Song = new DataGridViewTextBoxColumn();
            this.Artist = new DataGridViewLinkColumn();
            this.Album = new DataGridViewLinkColumn();
            this.Duration = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            this.Song,
            this.Artist,
            this.Album,
            this.Duration});
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new Point(0, 0);
            this.dataGridView1.Margin = new Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.HighlightText;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new Size(1032, 666);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseLeave += new DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            this.dataGridView1.CellMouseMove += new DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseMove);
            // 
            // Song
            // 
            this.Song.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Song.DataPropertyName = "Song";
            this.Song.HeaderText = "SONG";
            this.Song.Name = "Song";
            this.Song.ReadOnly = true;
            this.Song.Resizable = DataGridViewTriState.False;
            // 
            // Artist
            // 
            this.Artist.ActiveLinkColor = SystemColors.HighlightText;
            this.Artist.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Artist.DataPropertyName = "Artist";
            this.Artist.HeaderText = "ARTIST";
            this.Artist.LinkBehavior = LinkBehavior.HoverUnderline;
            this.Artist.LinkColor = SystemColors.HighlightText;
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            this.Artist.Resizable = DataGridViewTriState.False;
            this.Artist.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Artist.TrackVisitedState = false;
            // 
            // Album
            // 
            this.Album.ActiveLinkColor = SystemColors.HighlightText;
            this.Album.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Album.DataPropertyName = "Album";
            this.Album.HeaderText = "ALBUM";
            this.Album.LinkBehavior = LinkBehavior.HoverUnderline;
            this.Album.LinkColor = SystemColors.HighlightText;
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            this.Album.Resizable = DataGridViewTriState.False;
            this.Album.SortMode = DataGridViewColumnSortMode.Automatic;
            this.Album.TrackVisitedState = false;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "DURATION";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 136;
            // 
            // TrackListView
            // 
            this.AutoScaleDimensions = new SizeF(8F, 16F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Margin = new Padding(4, 4, 4, 4);
            this.Name = "TrackListView";
            this.Size = new Size(1032, 666);
            ((ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Song;
        private DataGridViewLinkColumn Artist;
        private DataGridViewLinkColumn Album;
        private DataGridViewTextBoxColumn Duration;
    }
}
