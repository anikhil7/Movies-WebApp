using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_L2V2.Models;

namespace WebApplication_L2V2.Data
{
    public class WebApplication_L2V2Context : DbContext
    {
        public WebApplication_L2V2Context (DbContextOptions<WebApplication_L2V2Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_L2V2.Models.Movies> Movies { get; set; } = default!;
    }
}
