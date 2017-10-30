using Filmoteka.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmoteka.Domain.Models.Library
{
    class Library : Entity, IAggregateRoot
    {
        private readonly List<LibraryItem> libraryItems;
        public IEnumerable<LibraryItem> LibraryItems => libraryItems.AsReadOnly();

        protected Library() { } // Design constraint needed only by EF Core
        public Library(int id)
        {
            Id = id;
        }
    }
}
