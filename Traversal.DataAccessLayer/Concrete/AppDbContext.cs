using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Traversal.DataAccessLayer.Concrete
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        
    }
}
