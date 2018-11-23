using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EapMvc.Models
{
    public class EapMvcContext : DbContext
    {
        public EapMvcContext (DbContextOptions<EapMvcContext> options)
            : base(options)
        {
        }

        public DbSet<EapMvc.Models.Employee> Employee { get; set; }
    }
}
