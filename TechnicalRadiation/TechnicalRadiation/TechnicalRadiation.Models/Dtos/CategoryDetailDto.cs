using System;
namespace TechnicalRadiation.TechnicalRadiation.Models.Dtos
{
    public class CategoryDetailDto
    {
        // Id of the category detail
        public int Id { get; set; }

        // name of the category detail
        public string Name { get; set; }

        // Slug of the category detail
        public string Slug { get; set; }

        // Number of news items in category
        public int NumberOfNewsItems { get; set; }
    }
}
