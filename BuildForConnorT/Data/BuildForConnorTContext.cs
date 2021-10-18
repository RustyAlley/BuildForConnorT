using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuildForConnorT.Models;

namespace BuildForConnorT.Data
{
    public class BuildForConnorTContext : DbContext
    {
        public BuildForConnorTContext (DbContextOptions<BuildForConnorTContext> options)
            : base(options)
        {
        }

        public DbSet<BuildForConnorT.Models.ItemModel> ItemModel { get; set; }
    }
}
