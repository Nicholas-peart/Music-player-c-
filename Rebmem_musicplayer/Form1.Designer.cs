
namespace Rebmem_musicplayer
{
    partial class music_player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(music_player));
            this.btn_shuffle = new System.Windows.Forms.PictureBox();
            this.btn_stop = new System.Windows.Forms.PictureBox();
            this.btn_preview = new System.Windows.Forms.PictureBox();
            this.btn_play = new System.Windows.Forms.PictureBox();
            this.btn_pause = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.PictureBox();
            this.btn_open = new System.Windows.Forms.PictureBox();
            this.track_list = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_display = new System.Windows.Forms.ComboBox();
            this.btn_loadplaylist = new System.Windows.Forms.Button();
            this.save_playlist = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_cleartracklist = new System.Windows.Forms.Button();
            this.btn_playlist = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_shuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_open)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.Image = ((System.Drawing.Image)(resources.GetObject("btn_shuffle.Image")));
            this.btn_shuffle.Location = new System.Drawing.Point(16, 498);
            this.btn_shuffle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(135, 118);
            this.btn_shuffle.TabIndex = 0;
            this.btn_shuffle.TabStop = false;
            this.btn_shuffle.Click += new System.EventHandler(this.btn_shuffle_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.Location = new System.Drawing.Point(159, 498);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(131, 118);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.TabStop = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.Image = ((System.Drawing.Image)(resources.GetObject("btn_preview.Image")));
            this.btn_preview.Location = new System.Drawing.Point(312, 498);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(144, 118);
            this.btn_preview.TabIndex = 2;
            this.btn_preview.TabStop = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_play
            // 
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.Location = new System.Drawing.Point(481, 498);
            this.btn_play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(135, 118);
            this.btn_play.TabIndex = 3;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_pause.Image")));
            this.btn_pause.Location = new System.Drawing.Point(641, 498);
            this.btn_pause.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(120, 118);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.TabStop = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_next
            // 
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(799, 498);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(120, 118);
            this.btn_next.TabIndex = 5;
            this.btn_next.TabStop = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_open
            // 
            this.btn_open.Image = ((System.Drawing.Image)(resources.GetObject("btn_open.Image")));
            this.btn_open.Location = new System.Drawing.Point(983, 498);
            this.btn_open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(143, 118);
            this.btn_open.TabIndex = 6;
            this.btn_open.TabStop = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // track_list
            // 
            this.track_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.track_list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.track_list.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.track_list.FormattingEnabled = true;
            this.track_list.ItemHeight = 16;
            this.track_list.Location = new System.Drawing.Point(25, 46);
            this.track_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.track_list.Name = "track_list";
            this.track_list.Size = new System.Drawing.Size(903, 272);
            this.track_list.TabIndex = 8;
            this.track_list.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_display);
            this.panel2.Controls.Add(this.btn_loadplaylist);
            this.panel2.Controls.Add(this.save_playlist);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_cleartracklist);
            this.panel2.Controls.Add(this.btn_playlist);
            this.panel2.Location = new System.Drawing.Point(941, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 479);
            this.panel2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(60, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose album";
            // 
            // cmb_display
            // 
            this.cmb_display.FormattingEnabled = true;
            this.cmb_display.Location = new System.Drawing.Point(21, 418);
            this.cmb_display.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_display.Name = "cmb_display";
            this.cmb_display.Size = new System.Drawing.Size(192, 24);
            this.cmb_display.TabIndex = 14;
            this.cmb_display.SelectedIndexChanged += new System.EventHandler(this.cmb_display_SelectedIndexChanged);
            // 
            // btn_loadplaylist
            // 
            this.btn_loadplaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_loadplaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadplaylist.ForeColor = System.Drawing.Color.Black;
            this.btn_loadplaylist.Location = new System.Drawing.Point(21, 193);
            this.btn_loadplaylist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_loadplaylist.Name = "btn_loadplaylist";
            this.btn_loadplaylist.Size = new System.Drawing.Size(193, 42);
            this.btn_loadplaylist.TabIndex = 13;
            this.btn_loadplaylist.Text = "Load playlist";
            this.btn_loadplaylist.UseVisualStyleBackColor = false;
            this.btn_loadplaylist.Click += new System.EventHandler(this.btn_loadplaylist_Click);
            // 
            // save_playlist
            // 
            this.save_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.save_playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_playlist.ForeColor = System.Drawing.Color.Black;
            this.save_playlist.Location = new System.Drawing.Point(21, 130);
            this.save_playlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.save_playlist.Name = "save_playlist";
            this.save_playlist.Size = new System.Drawing.Size(193, 38);
            this.save_playlist.TabIndex = 12;
            this.save_playlist.Text = "Save playlist";
            this.save_playlist.UseVisualStyleBackColor = false;
            this.save_playlist.Click += new System.EventHandler(this.save_playlist_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(21, 270);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(193, 43);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_cleartracklist
            // 
            this.btn_cleartracklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cleartracklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cleartracklist.ForeColor = System.Drawing.Color.Black;
            this.btn_cleartracklist.Location = new System.Drawing.Point(21, 334);
            this.btn_cleartracklist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cleartracklist.Name = "btn_cleartracklist";
            this.btn_cleartracklist.Size = new System.Drawing.Size(197, 42);
            this.btn_cleartracklist.TabIndex = 4;
            this.btn_cleartracklist.Text = "Clear track list";
            this.btn_cleartracklist.UseVisualStyleBackColor = false;
            this.btn_cleartracklist.Click += new System.EventHandler(this.btn_cleartracklist_Click);
            // 
            // btn_playlist
            // 
            this.btn_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playlist.ForeColor = System.Drawing.Color.Black;
            this.btn_playlist.Location = new System.Drawing.Point(21, 28);
            this.btn_playlist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(193, 78);
            this.btn_playlist.TabIndex = 0;
            this.btn_playlist.Text = "Create a playlist";
            this.btn_playlist.UseVisualStyleBackColor = false;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.track_list);
            this.panel1.Location = new System.Drawing.Point(-9, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 362);
            this.panel1.TabIndex = 20;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(79, 319);
            this.player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(713, 43);
            this.player.TabIndex = 20;
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(215, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rebmem Music Player";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-5, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 128);
            this.panel3.TabIndex = 21;
            // 
            // music_player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1181, 625);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_shuffle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "music_player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rebmem Music player";
            this.Load += new System.EventHandler(this.music_player_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.music_player_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.music_player_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.music_player_MouseDown);
            this.MouseEnter += new System.EventHandler(this.music_player_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.music_player_MouseLeave);
            this.MouseHover += new System.EventHandler(this.music_player_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.music_player_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.music_player_MouseUp);
            this.Move += new System.EventHandler(this.music_player_Move);
            ((System.ComponentModel.ISupportInitialize)(this.btn_shuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_open)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_shuffle;
        private System.Windows.Forms.PictureBox btn_stop;
        private System.Windows.Forms.PictureBox btn_preview;
        private System.Windows.Forms.PictureBox btn_play;
        private System.Windows.Forms.PictureBox btn_pause;
        private System.Windows.Forms.PictureBox btn_next;
        private System.Windows.Forms.PictureBox btn_open;
        private System.Windows.Forms.ListBox track_list;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cleartracklist;
        private System.Windows.Forms.Button btn_playlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button save_playlist;
        private System.Windows.Forms.Button btn_loadplaylist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_display;
        private System.Windows.Forms.Label label2;
    }
}

