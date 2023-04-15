using Knotes.Domain;
using Microsoft.EntityFrameworkCore;

namespace Knotes.Application.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
