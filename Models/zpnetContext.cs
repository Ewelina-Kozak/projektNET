using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using zpnet.Models;

namespace zpnet.Models
{
    public class zpnetContext : DbContext
    {
        public zpnetContext (DbContextOptions<zpnetContext> options)
            : base(options)
        {
        }

        public DbSet<zpnet.Models.Movie> Movie { get; set; } = default!;

        public DbSet<zpnet.Models.Category> Category { get; set; } = default!;

        public DbSet<zpnet.Models.Client> Client { get; set; } = default!;

        public DbSet<zpnet.Models.Rental> Rental { get; set; } = default!;


    }
}
