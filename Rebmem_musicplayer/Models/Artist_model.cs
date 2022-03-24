using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rebmem_musicplayer;
using Rebmem_musicplayer.Viewmodel;

namespace Rebmem_musicplayer
{
    public partial class Artist
    {
        public void Saveartist(string artistName)
        {
            using (var context = new Rebmem_MusicPlayerdbcontext())
            {
                //artist class
                Artist artist = new Artist();
                artist.artistName = artistName;
                context.Artists.Add(artist);
                context.SaveChanges();
            }
        }
        public List<Artistvm> GetAllArtist()
        {
            using (var context = new Rebmem_MusicPlayerdbcontext())
            {
                //fetching artist from the database and ordering by Id descending
                 return context.Artists.Select(a => new Artistvm { Name = a.artistName, Id = a.artistId }).OrderByDescending(x => x.Id).ToList();
                
            }
        }
    }
}
