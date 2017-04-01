using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Model
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Band(string name)
        {
            Name = name;
        }
    }
}
