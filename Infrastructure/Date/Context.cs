using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Date
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
          
        }

    }
}
