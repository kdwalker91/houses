using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace House.Data
{
    public class HouseContext : DbContext
    {
        public HouseContext (DbContextOptions<HouseContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication4.Models.House> House { get; set; }
    }
}
