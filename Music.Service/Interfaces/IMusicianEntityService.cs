using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Entities;

namespace Music.Service.Interfaces
{
    public interface IMusicianEntityService
    {
        MusicianEntity SaveMusician(MusicianEntity musician, int? id);
        MusicianEntity DeleteMusician(int id);
        MusicianEntity GetMusician(int id);
        IEnumerable<MusicianEntity> GetAllMusicians();
    }
}
