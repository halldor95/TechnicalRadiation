using System;
namespace TechnicalRadiation.TechnicalRadiation.Models.Dtos
{
    public class AuthorDetailDto
    {
        // Id of the author detail
        public int Id { get; set; }

        // Name of the author detail
        public string Name { get; set; }

        // Profile image source of the author detail
        public string ProfileImgSource { get; set; }

        // Bio of the author
        public string Bio { get; set; }
    }
}
