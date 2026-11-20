using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenVanMinh_Day6.Models;

namespace NguyenVanMinh_Day6.Data
{
    public class NguyenVanMinh_Day6Context : DbContext
    {
        public NguyenVanMinh_Day6Context (DbContextOptions<NguyenVanMinh_Day6Context> options)
            : base(options)
        {
        }

        public DbSet<NguyenVanMinh_Day6.Models.Genre> Genre { get; set; } = default!;
        public DbSet<NguyenVanMinh_Day6.Models.Movie> Movie { get; set; } = default!;
    }
}
