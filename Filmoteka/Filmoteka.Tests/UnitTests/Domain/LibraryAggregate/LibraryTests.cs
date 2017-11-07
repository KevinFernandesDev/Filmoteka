using Filmoteka.Domain.Models.LibraryAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Filmoteka.Tests.UnitTests.Domain.LibraryAggregate
{
    public class LibraryTests
    {
        private Library library;
        public LibraryTests()
        {
            library = new Library(0);   
        }

        [Fact]
        public void Can_Add_New_LibraryItem_ToList()
        {
            // Arrange
            var expectedLibraryItem = new LibraryItem(69, "");

            // Act
            library.AddLibraryItem(expectedLibraryItem);

            // Assert
            Assert.Equal(expectedLibraryItem, library.LibraryItems.ElementAt(0));

        }
    }
}
