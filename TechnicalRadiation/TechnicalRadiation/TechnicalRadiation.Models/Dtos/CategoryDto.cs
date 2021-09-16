using System;
namespace TechnicalRadiation.TechnicalRadiation.Models.Dtos
{
    public class CategoryDto
    {
        // Id of the category
        public int Id { get; set; }

        // Name of the category
        public string Name { get; set; }

        // Slug of the category
        public string Slug { get; set; }
    }
}
