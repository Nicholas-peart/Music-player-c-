using Rebmem_musicplayer.Viewmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebmem_musicplayer
{
    public partial class Frmalbum : Form
    {
        public Frmalbum()
        {
            InitializeComponent();
        }
     
        private void Frmalbum_Load(object sender, EventArgs e)
        {
            LoadDataGridAlbum();
            using (var context = new Rebmem_MusicPlayerdbcontext()) //the allocated ojects within the using statement are aoutomatically disposed
            {
                Artist artist = new Artist();
                var result = artist.GetAllArtist();
                var arstistVM = new Artistvm() { Id = 0, Name = "Please Select" };
                result.Insert(0, arstistVM);//0 is the top index of the artistvm list
                cmb_artist.DataSource = result;
                cmb_artist.DisplayMember = "Name"; // What is actually displayed
                cmb_artist.ValueMember = "Id";
                //Stops the user from writing in the drop down box
                cmb_artist.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void LoadDataGridAlbum()
        {
            Album album = new Album();
            var allAlbums = album.GetAllAlbumsWithArtist();
            if (allAlbums.Any()) 
            {
                dataGridViewalbum.DataSource = allAlbums;//
                dataGridViewalbum.Columns["AlbumTitle"].HeaderText = " Album Title";
                dataGridViewalbum.Columns["ArtistName"].HeaderText = " Artist Name";

            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            int cntArtist = cmb_artist.Items.Count;
            if (cntArtist > 0)
            {
                int Id = ((Artistvm)cmb_artist.SelectedItem).Id;
                if (Id > 0)
                {
                    var albumTitle = txt_albumtitle.Text;
                    if (string.IsNullOrWhiteSpace(albumTitle))
                    {
                        MessageBox.Show("Please add album title");
                    }
                    else 
                    {
                        album.artistId = Id;
                        album.albumTitle = albumTitle;
                        var issave = album.SaveAlbum(album);
                        if (issave)
                        {
                            //clears albumtitle and artist name after save
                            txt_albumtitle.Text = string.Empty;
                            cmb_artist.SelectedIndex = 0;
                            MessageBox.Show("album saved successfully");
                            LoadDataGridAlbum();

                        }
                        else {
                            MessageBox.Show("Album not saved");
                        }
                       
                    }
                    
                }
                else {
                    MessageBox.Show("Please select artist name");
                }
            }
        }
    }
}
