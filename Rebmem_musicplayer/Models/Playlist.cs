using Rebmem_musicplayer.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebmem_musicplayer
{
    public partial class Playlist
    {
        //gets all the playlist from the database and returns it
        public List<Playlistvm> Getallplaylist() 
        {
            using (var context = new Rebmem_MusicPlayerdbcontext())
            {
                var playlist = context.Playlists.Select(a => new Playlistvm() { PName = a.PName, PId = a.PId }).OrderByDescending(x => x.PId).ToList();
                return playlist;

            }
            
        }
        
    }
}
