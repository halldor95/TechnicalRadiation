using System;
namespace TechnicalRadiation.TechnicalRadiation.Repositories.Entities
{
    public class NewsItemCategories
    {
        /*
            AuthorId
            NewsItemId
         */

        public int AuthorId { get; set; }
        public int NewsItemId { get; set; }


        // Navigation properties
        public NewsItem NewsItem { get; set; }
        public Author Author { get; set; }

    }
}
