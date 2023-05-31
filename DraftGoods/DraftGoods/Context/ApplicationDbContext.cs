using DraftGoods.Models;
using Microsoft.EntityFrameworkCore;

namespace DraftGoods.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
