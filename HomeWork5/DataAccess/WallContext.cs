
    using HomeWork5.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;
namespace HomeWork5.DataAccess
{
    public class WallContext : DbContext
    {
        public WallContext() : base()
        {
            Database.SetInitializer(new WallInitializer());
        }

        public DbSet<Post> Posts { get; set; }
    }
}