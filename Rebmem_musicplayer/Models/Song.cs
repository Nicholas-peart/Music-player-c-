using Rebmem_musicplayer.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebmem_musicplayer
{
    public partial class Song
    {
        public List<Songvm> GetSongsByTitle(string title) 
        {
            using (var context = new Rebmem_MusicPlayerdbcontext())
            {
                // all songs that are avaiablie in the database that match with song title  
                var songs = from m in context.Songs where m.songTitle.Contains(title)
                select new Songvm{Id = m.songId, Name = m.songTitle};
                return songs.ToList();

            }
        }
        public Song GetSongById(int songId)
        {
            using (var context = new Rebmem_MusicPlayerdbcontext())
            {
                var song = context.Songs.FirstOrDefault(x => x.songId == songId);
                return song;
            }
        }
        public List<Song> GetSongByAlbumId(int albumId)
        {
            using (var context = new Rebmem_MusicPlayerdbcontext())
            {
                var songs = context.Songs.Where(x => x.albumId == albumId).ToList();
                return songs;
            }
        }
    }
}
