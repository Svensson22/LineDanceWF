using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LineDanceWF.Data
{
    internal class Dance
    {
        public int DanceId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public Song? SourceSong { get; set; }
        public virtual ObservableCollectionListSource<Song>? Alternatives { get; set; }
    }
}
