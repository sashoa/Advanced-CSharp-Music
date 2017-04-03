using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.BusinessLogic.Models
{
    public interface IArtist
    {
        int Id { get; set; }
        string Name { get; set; }
        List<Album> Albums { get; }

        void PublishAlbum(Album album);
    }
}
