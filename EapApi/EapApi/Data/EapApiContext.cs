using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EapApi.Models
{
    public class EapApiContext : DbContext
    {
        public EapApiContext (DbContextOptions<EapApiContext> options)
            : base(options)
        {
        }

        public DbSet<EapApi.Models.Employee> Employee { get; set; }
    }
}
