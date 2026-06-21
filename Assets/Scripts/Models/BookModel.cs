using System;

namespace WordsOnTheWaves.Models
{
    [Serializable]
    public class BookModel
    {
        public string bookId;
        public BookGenre genre;
        public int basePrice;
    }
}
