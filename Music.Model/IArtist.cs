using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Model
{
    /// <summary>
    /// Interface for Musician and Band
    /// </summary>
    public interface IArtist
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
