using apbdtask10_v2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace apbdtask10_v2.Data
{
    public class DatabaseContext : IdentityDbContext<AppUser>
    {
        public DbSet<UserNote> UserNotes { get; set; }
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected DatabaseContext()
        {
        }
    }
}
