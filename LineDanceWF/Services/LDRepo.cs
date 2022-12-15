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
    }
}
