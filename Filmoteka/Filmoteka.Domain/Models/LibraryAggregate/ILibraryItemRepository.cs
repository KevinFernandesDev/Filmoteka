using System;
using System.Collections.Generic;
using System.Text;
using Filmoteka.Domain.SeedWork;
using System.Threading.Tasks;
using System.Linq;

namespace Filmoteka.Domain.Models.LibraryAggregate
{
    public interface ILibraryRepository : IRepository<Library>
    {
        LibraryItem Add(LibraryItem libraryItem);
        LibraryItem Update(LibraryItem libraryItem);
        Task<LibraryItem> FindAsync(string LibraryItemIdentityGuid);

        Task<List<LibraryItem>> GetAll(int userId);
    }
}
