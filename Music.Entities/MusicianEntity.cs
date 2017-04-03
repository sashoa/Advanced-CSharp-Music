using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Entities
{
    public class MusicianEntity : IEntity, IArtistEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MusicianEntity(string name, int? bandId)
        {
            Name = name;
        }
    }
}
