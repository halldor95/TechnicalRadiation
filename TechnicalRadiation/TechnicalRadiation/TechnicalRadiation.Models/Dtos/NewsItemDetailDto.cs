using System;
namespace TechnicalRadiation.TechnicalRadiation.Models.Dtos
{
    public class NewsItemDetailDto
    {
        // Id of the news item detail
        public int Id { get; set; }

        // Title of the news item detail
        public string Title { get; set; }

        // Image source of the news item detail
        public string ImgSource { get; set; }

        // Short description of the news item detail
        public string ShortDescription { get; set; }

        // Long description of the news item detail
        public string LongDescription { get; set; }

        // Publish date of the news item detail
        public DateTime PublishDate { get; set; }
    }
}
