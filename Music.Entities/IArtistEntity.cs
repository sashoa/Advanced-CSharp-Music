﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.Entities
{
    public interface IArtistEntity
    {
        int Id { get; }
        string Name { get; set; }
    }
}
