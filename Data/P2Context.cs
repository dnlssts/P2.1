using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P2.Models;

namespace P2.Data
{
    public class P2Context : DbContext
    {
        public P2Context (DbContextOptions<P2Context> options)
            : base(options)
        {
        }

        public DbSet<P2.Models.Cliente> Cliente { get; set; } = default!;
    }
}
