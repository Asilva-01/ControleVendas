using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendasWebMVC_3.Models
{
    public class VendasWebMVC_3Context : DbContext
    {
        public VendasWebMVC_3Context (DbContextOptions<VendasWebMVC_3Context> options)
            : base(options)
        {
        }

        public DbSet<VendasWebMVC_3.Models.Departamento> Departamento { get; set; }
    }
}
