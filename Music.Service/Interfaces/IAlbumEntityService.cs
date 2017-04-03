using Music.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Service.Interfaces
{
    public interface IAlbumEntityService
    {
        AlbumEntity SaveAlbum(AlbumEntity album, int? id);
        AlbumEntity DeleteAlbum(int id);
        AlbumEntity GetAlbum(int id);
        IEnumerable<AlbumEntity> GetAllAlbums();
    }
}
