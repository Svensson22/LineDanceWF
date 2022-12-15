using LineDanceWF.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineDanceWF.Services
{
    internal class LDContext : DbContext
    {
        public LDContext(DbContextOptions<LDContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlite("Data Source=linedancing.db");

        public DbSet<Dance>? Dances { get; set; }
        public DbSet<Song>? Songs { get; set; }
        public DbSet<Playlist>? Playlists { get; set; }
    }
}
