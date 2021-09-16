using System;
using Microsoft.EntityFrameworkCore;
namespace TechnicalRadiation.TechnicalRadiation.Repositories.Data
{
    public class NewDbContext: DbContext
    {
        public NewDbContext(DbContextOptions<NewDbContext> options) : base(options) { }
    
    }
}
