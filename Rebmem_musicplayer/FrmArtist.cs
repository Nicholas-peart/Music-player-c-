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
    public partial class FrmArtist : Form
    {
        public FrmArtist()
        {
            InitializeComponent();
        }

        private void btn_saveartist_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_artistname.Text))
            {
                MessageBox.Show("Please add artist name");
            }else{
               
                
                    //artist class
                    Artist artist = new Artist();
                    artist.Saveartist(txt_artistname.Text);
                    Gridviewload();
                    txt_artistname.Text = string.Empty;
                
            }
        }

        private void FrmArtist_Load(object sender, EventArgs e)
        {
            Gridviewload();
        }
        private void Gridviewload() 
        {
            Artist artist = new Artist();
            var artists = artist.GetAllArtist();
            if (artists.Any()) 
            {
                //fetching artist from the database and ordering by Id descending
                dataGridViewartist.DataSource = artists;
                dataGridViewartist.Columns["Id"].Visible = false;
            }
            
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
