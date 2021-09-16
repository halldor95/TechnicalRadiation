using System;
using Microsoft.EntityFrameworkCore;
namespace TechnicalRadiation.TechnicalRadiation.Repositories.Data

{
    public class NewsDbContext: DbContext
    {
        public NewsDbContext(DbContextOptions<NewsDbContext> options) : base(options) { }
    }
}
