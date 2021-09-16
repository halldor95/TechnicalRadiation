using System;
namespace TechnicalRadiation.TechnicalRadiation.Repositories.Entities
{
    public class NewsItemCategories
    {
        /*
         CategoryId
         NewsItemId
         */

        public int CategoryId { get; set; }

        public int NewsItemId { get; set; }


        // Navigation properties

        public NewsItem NewsItem { get; set; }
        public Category Category { get; set; }


    }
}
