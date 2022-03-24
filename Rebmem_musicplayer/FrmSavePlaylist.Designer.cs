
namespace Rebmem_musicplayer
{
    partial class FrmSavePlaylist
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
            this.txtPlaylistName = new System.Windows.Forms.TextBox();
            this.lbl_playlistname = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_createartist = new System.Windows.Forms.Button();
            this.btn_createalbum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_album = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlaylistName
            // 
            this.txtPlaylistName.Location = new System.Drawing.Point(218, 226);
            this.txtPlaylistName.Name = "txtPlaylistName";
            this.txtPlaylistName.Size = new System.Drawing.Size(376, 20);
            this.txtPlaylistName.TabIndex = 1;
            this.txtPlaylistName.TextChanged += new System.EventHandler(this.txtPlaylistName_TextChanged);
            // 
            // lbl_playlistname
            // 
            this.lbl_playlistname.AutoSize = true;
            this.lbl_playlistname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playlistname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_playlistname.Location = new System.Drawing.Point(296, 196);
            this.lbl_playlistname.Name = "lbl_playlistname";
            this.lbl_playlistname.Size = new System.Drawing.Size(192, 16);
            this.lbl_playlistname.TabIndex = 4;
            this.lbl_playlistname.Text = "Please enter playlist name";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(228, 252);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 45);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(477, 252);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(88, 45);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_createartist
            // 
            this.btn_createartist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_createartist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createartist.ForeColor = System.Drawing.Color.Black;
            this.btn_createartist.Location = new System.Drawing.Point(634, 58);
            this.btn_createartist.Name = "btn_createartist";
            this.btn_createartist.Size = new System.Drawing.Size(88, 45);
            this.btn_createartist.TabIndex = 7;
            this.btn_createartist.Text = "Create artist";
            this.btn_createartist.UseVisualStyleBackColor = false;
            this.btn_createartist.Click += new System.EventHandler(this.btn_createartist_Click);
            // 
            // btn_createalbum
            // 
            this.btn_createalbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_createalbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createalbum.ForeColor = System.Drawing.Color.Black;
            this.btn_createalbum.Location = new System.Drawing.Point(634, 133);
            this.btn_createalbum.Name = "btn_createalbum";
            this.btn_createalbum.Size = new System.Drawing.Size(88, 45);
            this.btn_createalbum.TabIndex = 8;
            this.btn_createalbum.Text = "Create album";
            this.btn_createalbum.UseVisualStyleBackColor = false;
            this.btn_createalbum.Click += new System.EventHandler(this.btn_createalbum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(211, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Rebmem Music Player";
            // 
            // cmb_album
            // 
            this.cmb_album.FormattingEnabled = true;
            this.cmb_album.Location = new System.Drawing.Point(218, 153);
            this.cmb_album.Name = "cmb_album";
            this.cmb_album.Size = new System.Drawing.Size(376, 21);
            this.cmb_album.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(296, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Please enter album name";
            // 
            // FrmSavePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_album);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_createalbum);
            this.Controls.Add(this.btn_createartist);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_playlistname);
            this.Controls.Add(this.txtPlaylistName);
            this.Name = "FrmSavePlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSavePlaylist";
            this.Load += new System.EventHandler(this.FrmSavePlaylist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaylistName;
        private System.Windows.Forms.Label lbl_playlistname;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_createartist;
        private System.Windows.Forms.Button btn_createalbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_album;
        private System.Windows.Forms.Label label1;
    }
}