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
        public LDContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlite("Data Source=linedancing.db");

        public DbSet<Dance>? Dances { get; set; }
        public DbSet<Song>? Songs { get; set; }
        public DbSet<Playlist>? Playlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>()
                .HasMany(s => s.Dances)
                .WithMany(p => p.Alternatives)
                .UsingEntity(j => j.ToTable("DanceSongs"));

            modelBuilder.Entity<Dance>()
                .HasOne(d => d.OriginalSong);

            modelBuilder.Entity<Playlist>()
                .HasMany(p => p.Dances)
                .WithMany(p => p.Playlists)
                .UsingEntity(j => j.ToTable("PlaylistDances"));
        }
    }
}
