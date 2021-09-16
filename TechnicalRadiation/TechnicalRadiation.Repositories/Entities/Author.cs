using System;
using System.Collections.Generic;

namespace TechnicalRadiation.TechnicalRadiation.Repositories.Entities
{
    public class Author
    {
        /*
        Id,
        Name,
        ProfileImgSource,
        Bio,
        ModifiedBy (code-generated),
        CreatedDate (code- generated),
        ModifiedDate (code-generated)
        */
        public int Id { get; set; }

        public string Name { get; set; }

        public string ProfileImgSource { get; set; }

        public string Bio { get; set; }

        public DateTime ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        // Navigation properties

        public ICollection<NewsItemCategories> AuthorLink { get; set; }
    }
}
