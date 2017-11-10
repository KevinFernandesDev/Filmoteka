using Filmoteka.Domain.SeedWork;

namespace Filmoteka.Domain.Models.LibraryAggregate
{
    public class LibraryItem : Entity
    {
        public int? MediaId { get; private set; }
        public string MediaPoster { get; private set; }

        public LibraryItem(int expectedMediaMediaId, string expectedMediaPoster)
        {
            MediaId = expectedMediaMediaId;
            MediaPoster = expectedMediaPoster;
        }
    }
}