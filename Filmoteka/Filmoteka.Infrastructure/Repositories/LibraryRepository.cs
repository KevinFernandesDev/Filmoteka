using Filmoteka.Domain.Models.LibraryAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using Filmoteka.Domain.SeedWork;
using System.Threading.Tasks;
using System.Linq;

namespace Filmoteka.Infrastructure.Repositories
{
    class LibraryRepository : ILibraryRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public IUnitOfWork UnitOfWork { get { return applicationDbContext; } }

        public LibraryRepository(ApplicationDbContext context)
        {
            if(context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }
            applicationDbContext = context;
        }

        public LibraryItem Add(LibraryItem buyer)
        {
            throw new NotImplementedException();
        }

        public Task<LibraryItem> FindAsync(string LibraryItemIdentityGuid)
        {
            throw new NotImplementedException();
        }

        public LibraryItem Update(LibraryItem buyer)
        {
            throw new NotImplementedException();
        }

        public async Task<List<LibraryItem>> GetAll(int userId)
        {
            /*var libraryItems = await applicationDbContext.LibraryItems.All(x => x.MediaId);
            return libraryItems;*/
            return null;
        }
    }
}
