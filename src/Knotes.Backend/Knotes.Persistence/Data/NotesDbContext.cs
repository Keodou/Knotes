using Knotes.Application.Interfaces;
using Knotes.Domain;
using Knotes.Persistence.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Knotes.Persistence.Data
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get; set; }

        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new NoteConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
