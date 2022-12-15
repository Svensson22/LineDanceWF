using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDanceWF.Data
{
    internal class Playlist
    {
        public int PlaylistId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public DateTime? LastUpdated { get; set; } = DateTime.Now;
        public virtual ObservableCollectionListSource<Dance>? Dances { get; set; }

    }
}
