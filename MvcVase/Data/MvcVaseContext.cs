using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcVase.Models;

namespace MvcVase.Data
{
    public class MvcVaseContext : DbContext
    {
        public MvcVaseContext (DbContextOptions<MvcVaseContext> options)
            : base(options)
        {
        }

        public DbSet<MvcVase.Models.Vase> Vase { get; set; }
    }
}
