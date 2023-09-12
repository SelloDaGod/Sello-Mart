using Sello_Mart.Model;
using Microsoft.EntityFrameworkCore;

namespace Sello_Mart
{
    public class CommyDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public CommyDBContext(DbContextOptions options) : base(options)
        { }
    }
}