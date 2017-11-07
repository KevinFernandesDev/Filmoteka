using System;
using System.Collections.Generic;
using System.Text;
using Filmoteka.Domain.Models.LibraryAggregate;
using Xunit;

namespace Filmoteka.Tests.UnitTests.Domain.LibraryAggregate
{
    public class LibraryItemTests
    {
        [Fact]
        public void Given_MediaId_While_Creating_Object_Should_Return_Same_Id()
        {
            // Arrange
            int expectedMediaId = 50;
            var libraryItem = new LibraryItem(expectedMediaId, "");
            
            // Act
            int actualMediaId = libraryItem.MediaId;

            // Assert
            Assert.Equal(expectedMediaId, actualMediaId);
        }

        [Fact]
        public void Given_Base64_Image_While_Creating_Object_Should_Return_Same_Base64_Image()
        {
            // Arrange
            string expectedMediaPoster = "data:image/gif;base64,R0lGODlhAQABAAAAACw=";
            var libraryItem = new LibraryItem(50, expectedMediaPoster);

            // Act
            string actualMediaPoster = libraryItem.MediaPoster;

            // Assert
            Assert.Equal(expectedMediaPoster, actualMediaPoster);
        }
    }
}
