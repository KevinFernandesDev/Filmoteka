using Filmoteka.Domain.Models.LibraryAggregate;
using Filmoteka.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Filmoteka.Infrastructure
{
    class ApplicationDbContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "filmoteka";

        public DbSet<Library> Libraries { get; set; }
        public DbSet<LibraryItem> LibraryItems { get; set; }

        private ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }
    }
}
