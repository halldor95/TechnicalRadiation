using System;
using System.Collections.Generic;

namespace TechnicalRadiation.TechnicalRadiation.Repositories.Entities
{
    public class Category
    {
        /*
        Id,
        Name,
        Slug,
        ModifiedBy (code-generated),
        CreatedDate (code-generated),
        ModifiedDate (code-generated)
        */
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public DateTime ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        // Navigation properties

        public ICollection<NewsItemCategories> CategoriesLink { get; set; }
    }
}
