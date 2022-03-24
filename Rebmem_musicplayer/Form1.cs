using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Rebmem_musicplayer.Viewmodel;

namespace Rebmem_musicplayer
{
    public partial class music_player : Form
    {
        Timer timer = new Timer();//intialize timer object
        Dictionary<string, Color> dicBackColor = new Dictionary<string, Color>();//save list of button control colors 
        // this list object will save file paths
        List<string> pathsList = new List<string>();
        public music_player()
        {
            InitializeComponent();
        }

        //Creating variable names for string array
        string[] paths, files;


        private void btn_open_Click(object sender, EventArgs e)
        {
            CreatePlaylist();
  
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            //if next button is pressed then change to the next song from track_list
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            //if pause button is pressed, then the music will pause
            player.Ctlcontrols.pause();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            //if play button is pressed, then the music will play
            player.Ctlcontrols.play();
            
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            //if preview button is pressed then change to the previous song from track_list
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            //if stop button is pressed, then the music will stop
            player.Ctlcontrols.stop();
        }


        private void btn_shuffle_Click(object sender, EventArgs e)
        {
            int totalItems = track_list.Items.Count;
            Random random = new Random();
            //return a random integer within a specified range
            int randomItemIndex = random.Next(0, totalItems);
            player.URL = pathsList[randomItemIndex];
            player.Ctlcontrols.play();
            track_list.SelectedIndex = randomItemIndex;
            track_list.SelectedItem = true;
        }


        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = pathsList[track_list.SelectedIndex];
            player.Ctlcontrols.play();
        }
        private void CreatePlaylist() 
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //User can select multiple files
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < openFile.SafeFileNames.Length; i++)
                {
                    //open files and adds items to track_list
                    track_list.Items.Add(openFile.SafeFileNames[i]);
                    pathsList.Add(openFile.FileNames[i]);
                }
                //If the length of the files been uploaded is greater than 0, then clear the track list
                if (openFile.SafeFileNames.Length > 0)
                {
                    btn_cleartracklist.Enabled = true;
                }
            }
        }
        private void btn_playlist_Click(object sender, EventArgs e)
        {

            CreatePlaylist();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {   //Created a Frmsearch object
            Frmsearch frmsearch = new Frmsearch();
            //Shows the search form window
            frmsearch.ShowDialog();
            int songId = Frmsearch.SongId;
            //Created a Song object
            Song song = new Song();
            var fullSong = song.GetSongById(songId);
            //If the song is in the database, then execute below statement
            if (fullSong != null)
            {
                track_list.Items.Clear();
                pathsList.Clear();
                track_list.Items.Add(fullSong.songTitle);
                pathsList.Add(fullSong.songFilePath);
            }
        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void btn_loadplaylist_Click(object sender, EventArgs e)
        {
            //links FrmLoadPlaylist to the load playlist button 
            FrmLoadPlaylist loadPlaylist = new FrmLoadPlaylist();
            loadPlaylist.ShowDialog();
            int playlistId = FrmLoadPlaylist.PlaylistId;
            if (playlistId > 0)
            {
                using (var context = new Rebmem_MusicPlayerdbcontext())
                {
                    //Fetching the playlist from the database by Id and return playlist other return null
                    var playlist = context.Playlists.Where(p => p.PId == playlistId).FirstOrDefault();
                    if (playlist != null)
                    {
                        var songs = playlist.Songs.ToList();//To list returns all the songs which that are attached to the playlist
                        for (int i = 0; i < songs.Count; i++)
                        {
                            track_list.Items.Add(songs[i].songTitle);
                            pathsList.Add(songs[i].songFilePath);
                        }
                    }
                }
                playlistId = 0; //Here I am deleting the playlist value by assiging it to 0
            } 
        }
        void timer_Tick(object sender, EventArgs e)//
        {
            if (!dicBackColor.ContainsKey(this.Name))//containskey is string
            {
                dicBackColor.Add(this.Name, this.BackColor);//add the name of form and backcolor
            }
            this.BackColor = Color.Black;
            foreach (Control control in this.Controls)
            {
                UpdateColorControls(control);
            }
        }
        public void RestoreColorControls(Control myControl)
        {
            dicBackColor.Clear();// clears back colour
            myControl.Visible = true;
            foreach (Control subControl in myControl.Controls)
            {
                RestoreColorControls(subControl);
            }
        }
        public void UpdateColorControls(Control myControl)// update color method will hide controls and subcontrols
        {
            myControl.Visible = false;//hides myControl
            foreach (Control subControl in myControl.Controls)
            {
                UpdateColorControls(subControl);//recursive function
            }
        }
        private void music_player_Load(object sender, EventArgs e)
        {
            timer.Interval = 10000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            Album album = new Album();
            var allAlbums = album.GetAlbums();// gets all albums from the database and assigns them to the allalbums varibale
            if (allAlbums.Any()) //If any albums are found, execute below statement
            {
                var albumvm = new Albumvm() { Id = 0, AlbumTitle = "Please Select" };
                allAlbums.Insert(0, albumvm);
                cmb_display.DataSource = allAlbums;// all the albums in the database and assign to the combo box
                cmb_display.DisplayMember = "AlbumTitle";//The column that is shown
                cmb_display.ValueMember = "Id";//This value is for database operations in the back-end
            }
                cmb_display.DropDownStyle = ComboBoxStyle.DropDownList;
            isFrmLoading = false;// The form has loaded
        }
            
        private void btn_cleartracklist_Click(object sender, EventArgs e)
        {
            track_list.Items.Clear();
        }
        bool isFrmLoading = true; 
        private void cmb_display_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFrmLoading)
            {
                return;
            }
            int cmbCount = cmb_display.Items.Count;
            if (cmbCount > 0)
            {
                int Id = ((Albumvm)cmb_display.SelectedItem).Id;
                if (Id > 0)
                {
                    Song song = new Song();
                    var songs = song.GetSongByAlbumId(Id);
                    if (songs.Any())
                    {
                        track_list.Items.Clear();
                        pathsList.Clear();
                        //stops the song
                        player.URL = null;
                        for (int i = 0; i < songs.Count; i++)
                        {
                            track_list.Items.Add(songs[i].songTitle);
                            pathsList.Add(songs[i].songFilePath);
                        }
                    }
                    else {
                        MessageBox.Show("This album contains no songs");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please select album");
                }
            }
        }

        private void music_player_MouseHover(object sender, EventArgs e)//
        {
            if(dicBackColor.ContainsKey(this.Name))
            {
                this.BackColor = dicBackColor[this.Name];
            }
            foreach (Control control in this.Controls)
            {
                RestoreColorControls(control);
            }
            //Stops and restarts the time
            timer.Stop();
            timer.Start();
        }

        private void music_player_MouseMove(object sender, MouseEventArgs e)
        {
            if (dicBackColor.ContainsKey(this.Name))
            {
                this.BackColor = dicBackColor[this.Name];
            }
            foreach (Control c in this.Controls)
            {
                RestoreColorControls(c);
            }
            timer.Stop();
            timer.Start();
        }

        private void music_player_MouseLeave(object sender, EventArgs e)
        {
            if (dicBackColor.ContainsKey(this.Name))
            {
                this.BackColor = dicBackColor[this.Name];
            }
            foreach (Control c in this.Controls)
            {
                RestoreColorControls(c);
            }
            timer.Stop();
            timer.Start();
        }

        private void music_player_MouseUp(object sender, MouseEventArgs e)
        {
            if (dicBackColor.ContainsKey(this.Name))
            {
                this.BackColor = dicBackColor[this.Name];
            }
            foreach (Control c in this.Controls)
            {
                RestoreColorControls(c);
            }
            timer.Stop();
            timer.Start();
        }

        private void music_player_MouseDown(object sender, MouseEventArgs e)
        {
            if (dicBackColor.ContainsKey(this.Name))
            {
                this.BackColor = dicBackColor[this.Name];
            }
            foreach (Control c in this.Controls)
            {
                RestoreColorControls(c);
            }
            timer.Stop();
            timer.Start();
        }

        private void music_player_MouseEnter(object sender, EventArgs e)
        {
           if (dicBackColor.ContainsKey(this.Name))
            {
                this.BackColor = dicBackColor[this.Name];
            }
            foreach (Control c in this.Controls)
            {
                RestoreColorControls(c);
            }
            timer.Stop();
            timer.Start();
        }

        private void music_player_MouseClick(object sender, MouseEventArgs e)
        {
            if (dicBackColor.ContainsKey(this.Name))
            {
                this.BackColor = dicBackColor[this.Name];
            }
            foreach (Control c in this.Controls)
            {
                RestoreColorControls(c);
            }
            timer.Stop();
            timer.Start();
        }

        private void music_player_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dicBackColor.ContainsKey(this.Name))
            {
                this.BackColor = dicBackColor[this.Name];
            }
            foreach (Control c in this.Controls)
            {
                RestoreColorControls(c);
            }
            timer.Stop();
            timer.Start();
        }

        private void music_player_Move(object sender, EventArgs e)
        {
            if (dicBackColor.ContainsKey(this.Name))
            {
                this.BackColor = dicBackColor[this.Name];
            }
            foreach (Control c in this.Controls)
            {
                RestoreColorControls(c);
            }
            timer.Stop();
            timer.Start();
        }

        private void save_playlist_Click(object sender, EventArgs e)
        {
            if (track_list.Items.Count == 0)
            {
                MessageBox.Show("Please create a playlist");

            }
            else
            {
                //create a playlist object
                Playlist playlist = new Playlist();
                List<Song> songs = new List<Song>();
                //loop values in list box
                for (int index = 0; index < track_list.Items.Count; index++)
                {
                    Song song = new Song();
                    song.songTitle = track_list.Items[index].ToString();
                    song.songFilePath = pathsList[index];
                    songs.Add(song);
                }
                FrmSavePlaylist frmSavePlaylist = new FrmSavePlaylist(songs);

                //show frmsaveplaylist dialog
                frmSavePlaylist.ShowDialog();
            }
            if (track_list.Items.Count == 23)
            {
                MessageBox.Show("Your playlist has been saved");
            }
        }

    }
}
