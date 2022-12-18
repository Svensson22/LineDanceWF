using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LineDanceWF.Data
{
    internal class Song
    {
        public int SongId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FileHash { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public virtual ObservableCollectionListSource<Dance>? Dances { get; set; }= new ObservableCollectionListSource<Dance>();
    }
}
