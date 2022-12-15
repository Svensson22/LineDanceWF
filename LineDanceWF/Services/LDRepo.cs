using LineDanceWF.Data;

namespace LineDanceWF.Services
{
    internal class LDRepo
    {
        private LDContext _db;

        public LDRepo(LDContext db)
        {
            _db = db;
        }

        public void DemoMetod()
        {
            // Prata med injectad dbcontext
            var x = _db.Songs;
        }

        public void AddSong(Song song)
        {
            _db.Songs.Add(song);
            _db.SaveChanges();
        }
        public void DeleteSong(Song song)
        {
            _db.Songs.Remove(song);
            _db.SaveChanges();
        }
        public void EditSong(Song song)
        {
            _db.Songs.Update(song);
            _db.SaveChanges();
        }
        public void AddDance(Dance dance)
        {
            _db.Dances.Add(dance);
            _db.SaveChanges();
        }
        public void DeleteDance(Dance dance)
        {
            _db.Dances.Remove(dance);
            _db.SaveChanges();
        }
        public void EditDance(Dance dance)
        {
            _db.Dances.Update(dance);
            _db.SaveChanges();
        }
        

    }
}
