using System;
using System.Collections.Generic;
using System.Text;
using Filmoteka.Domain.Models.LibraryAggregate;
using Filmoteka.Domain.SeedWork;
using MediatR;
using Xunit;

namespace Filmoteka.Tests.UnitTests.Domain.SeedWork
{
    class EntityTests
    {
        [Fact]
        public void Can_Add_DomainEvent()
        {
            // Arrange
            var entity = new Library(0);
            var notification = 

            // Act
            entity.AddDomainEvent(new INotification());

            // Assert
        }
    }
}
