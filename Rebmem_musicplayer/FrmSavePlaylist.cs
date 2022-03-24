using Rebmem_musicplayer.Viewmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebmem_musicplayer
{
    public partial class FrmSavePlaylist : Form
    {
        private List<Song> _songs;
        public FrmSavePlaylist(List<Song> songs)
        {
            _songs = songs;
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
           
            txtPlaylistName.Text = string.Empty;
           // _playlist = null;
            this.Visible = false;
        }
  
        private void btn_save_Click(object sender, EventArgs e)
        {
            int cmbCount = cmb_album.Items.Count;
            if (cmbCount > 0) 
            {
                int Id = ((Albumvm)cmb_album.SelectedItem).Id;
                if (Id < 1)
                {
                    MessageBox.Show("Please select album");
                    return;
                }
                //if value is not empty then assign name to playlist
                if (!string.IsNullOrWhiteSpace(txtPlaylistName.Text))
                {
                    using (var context = new Rebmem_MusicPlayerdbcontext())
                    {
                        Playlist playlist = new Playlist();
                        playlist.PName = txtPlaylistName.Text;
                        //saves current date time
                        playlist.PAddedDate = DateTime.Now;
                        context.Playlists.Add(playlist);
                        foreach (var song in _songs)
                        {
                            song.albumId = Id;
                        }
                        context.Songs.AddRange(_songs);

                        //saves in database
                        context.SaveChanges();
                        //Fecthing playlist Id from the database
                        var play_list = context.Playlists.OrderByDescending(x => x.PId).FirstOrDefault();
                        foreach (var s in _songs)
                        {
                            play_list.Songs.Add(s);
                        }
                        context.SaveChanges();
                        MessageBox.Show("Playlist saved successfully");
                        txtPlaylistName.Text = string.Empty;
                        _songs = null;
                        //hides form
                        this.Visible = false;
                    }

                }
                else 
                {
                    MessageBox.Show("Please add playlist name");
                }
            }
            else
            {
                MessageBox.Show("Please create an album");
            }
        }

        private void txtPlaylistName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_createartist_Click(object sender, EventArgs e)
        {
            FrmArtist frmArtist = new FrmArtist();
            frmArtist.ShowDialog();
        }

        private void btn_createalbum_Click(object sender, EventArgs e)
        {
            Frmalbum frmalbum = new Frmalbum();
            frmalbum.ShowDialog();
        }

        private void FrmSavePlaylist_Load(object sender, EventArgs e)
        {
            Album album = new Album();
            var allAlbums = album.GetAlbums();
            if (allAlbums.Any())
            {
                var albumvm = new Albumvm() { Id = 0, AlbumTitle = "Plese Select" };
                allAlbums.Insert(0, albumvm);
                //Assign album to combo box
                cmb_album.DataSource = allAlbums;
                cmb_album.DisplayMember = "AlbumTitle";
                cmb_album.ValueMember = "Id";
            }
            cmb_album.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
