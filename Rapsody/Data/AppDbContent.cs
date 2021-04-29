using Microsoft.EntityFrameworkCore;
using Rapsody.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Rapsody.Data
{
    public class AppDbContent : DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options) :base(options)
        {

        }

        public DbSet<Food> Food { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<RapsodyCartItem> RapsodyCartItem { get; set; }
    }
}
