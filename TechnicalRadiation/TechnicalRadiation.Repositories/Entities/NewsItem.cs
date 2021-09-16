using System;
using System.Collections.Generic;

namespace TechnicalRadiation.TechnicalRadiation.Repositories.Entities
{
    public class NewsItem
    {
        /*
        Id,
        Title,
        ImgSource,
        ShortDescription,
        LongDescription,
        PublishDate,
        ModifiedBy(code-generated),
        CreatedDate(code-generated),
        ModifiedDate(code-generated)
        */
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImgSource { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string PublishDate { get; set; }

        public DateTime ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        // Navigation properties

        public ICollection<NewsItemCategories> NewsItemLink { get; set; }

    }
}
