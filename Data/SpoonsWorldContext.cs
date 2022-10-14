using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpoonsWorld.Models;

namespace SpoonsWorld.Data
{
    public class SpoonsWorldContext :DbContext
    {
        public SpoonsWorldContext(DbContextOptions<SpoonsWorldContext> options)
           : base(options)
        {
        }

        public DbSet<Spoon> Spoon { get; set; }
    }
}
