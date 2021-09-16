using System;
namespace TechnicalRadiation.TechnicalRadiation.Models.Dtos
{
    public class NewsItemDto
    {
        // Id of the news item
        public int Id { get; set; }

        // Title of the news item
        public string Title { get; set; }

        // Image source of the news item
        public string ImgSource { get; set; }

        // A short description of the news item
        public string ShortDescription { get; set; }
    }
}
