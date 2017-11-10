using System;
using System.Collections.Generic;
using Filmoteka.Domain.SeedWork;

namespace Filmoteka.Domain.Models.LibraryAggregate
{
    public sealed class Library : Entity, IAggregateRoot
    {
        public int? UserId { get; private set; }

        private readonly List<LibraryItem> libraryItems;
        public IEnumerable<LibraryItem> LibraryItems => libraryItems.AsReadOnly();

        private Library() { } // Design constraint needed only by EF Core
        public Library(int userId)
        {
            UserId = userId;
            libraryItems = new List<LibraryItem>();
            Console.WriteLine(Id);
        }

        public void AddLibraryItem(LibraryItem libraryItem)
        {
            libraryItems.Add(libraryItem);
        }
    }
}
