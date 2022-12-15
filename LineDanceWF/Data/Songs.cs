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
        [Required]
        public int SongId { get; set; }
        string Name { get; set; } = string.Empty;
        string FileHash { get; set; } = string.Empty;
        string FilePath { get; set; } = string.Empty;

    }
}
