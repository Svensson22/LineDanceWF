using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDanceWF.Data
{
    internal class Songs
    {
        public int SongId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FileHash { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;

    }
}
