using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstTask.Models;

namespace FirstTask.Data
{
    public class FirstTaskContext : DbContext
    {
        public FirstTaskContext (DbContextOptions<FirstTaskContext> options)
            : base(options)
        {
        }

        public DbSet<FirstTask.Models.Games> Games { get; set; }
    }
}
