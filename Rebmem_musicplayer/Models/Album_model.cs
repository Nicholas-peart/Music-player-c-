using Rebmem_musicplayer.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebmem_musicplayer
{
    public partial class Album
    {
        public bool SaveAlbum(Album album) 
        {
            try
            {
                using (var context = new Rebmem_MusicPlayerdbcontext())
                {
                    context.Albums.Add(album);
                    context.SaveChanges();
                    return true;

                }
            }
            catch(Exception ex) 
            {
                return false;
            }
            
        }
        public List<Albumvm> GetAllAlbumsWithArtist()
        {
            using (var context = new Rebmem_MusicPlayerdbcontext()) 
            {
                var result = context.Albums.Join(context.Artists,
                    alb => alb.artistId,//This is a column in the album table which is joining with artistId in the artist table
                    art => art.artistId, //This is a column in the artist table which is joining with artistId in the album table
                    (alb, art) => new Albumvm { AlbumTitle = alb.albumTitle, ArtistName = art.artistName }
                    ).ToList();
                return result;
            }
        }
        public List<Albumvm> GetAlbums()
        {
            using (var context = new Rebmem_MusicPlayerdbcontext())
            {
               var result = context.Albums.Select(alb => new Albumvm() { AlbumTitle = alb.albumTitle, Id = alb.albumId}).OrderByDescending(x => x.Id).ToList();

                return result;
            }
        }
    }
}
