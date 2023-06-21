using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SoftOnSale_V2.Models;

namespace SoftOnSale_V2.Data
{
    //This class is required for operating withDaraBase and connecting to it
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<ItemForSale> Item { get; set; }

        public DbSet<Category> Category { get; set; }

    }
}
