using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineDanceWF.Data
{
    internal class Dance
    {
        public int DanceId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public int? OrigninalSongID { get; set; }
        public Song? OrigninalSong { get; set; }
        public virtual ObservableCollectionListSource<Song>? Alternatives { get; set; }
        public virtual ObservableCollectionListSource<Playlist>? Playlists { get; set; }
    }
}
