using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LineDanceWF.Data
{
    internal class Dances
    {
        public int DanceId { get; set; }
        public string? Name { get; set; } = string.Empty;
        public Songs? SourceSong { get; set; }
        public virtual ObservableCollectionListSource<Songs>? Alternatives { get; set; }
    }
}
