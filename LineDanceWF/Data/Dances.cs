using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDanceWF.Data
{
    internal class Dances
    {
        [Required]
        int DanceId { get; set; }
        string? Name { get; set; }
        Songs? SourceSong { get; set; }
        List<Songs>? Alternatives { get; set; }
    }
}
