﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDanceWF.Data
{
    internal class Dances
    {
        public int DanceId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public Songs? SourceSong { get; set; }
        public virtual List<Songs>? Alternatives { get; set; }
    }
}
