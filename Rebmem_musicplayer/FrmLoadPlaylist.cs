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
    public partial class FrmLoadPlaylist : Form
    {
        public static int PlaylistId { get; set; }
        public FrmLoadPlaylist()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //closes frmLoadPlaylist
            this.Visible = false;
        }

        private void FrmLoadPlaylist_Load(object sender, EventArgs e)
        {
            var playlist = new Playlist();
            var allplaylist = playlist.Getallplaylist();        //it will return all playlists from the database and assign to the allplaylist variable
            
            if (allplaylist.Any())
            {
                var playlistvm = new Playlistvm() { PId = 0, PName = "Please Select" };
                allplaylist.Insert(0, playlistvm);
                cmb_playlistname.DataSource = allplaylist;
                cmb_playlistname.DisplayMember = "PName";
                cmb_playlistname.ValueMember = "PId";
            }
            cmb_playlistname.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            // checking the total number of playlist
            int cmbcount = cmb_playlistname.Items.Count;
            if (cmbcount > 0)
            {
                int Id = ((Playlistvm)cmb_playlistname.SelectedItem).PId;
                if (Id > 0)
                {
                    PlaylistId = Id;
                
                    this.Visible = false;

                }
                else {
                    MessageBox.Show("Select a playlist from the dropdown list");
                }
            }
            else {
                MessageBox.Show("Please create a playlist");
            }
            

            
        }
    }
}
