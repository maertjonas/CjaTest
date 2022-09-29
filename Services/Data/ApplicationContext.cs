using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;
using Services.Data.Configurations;

namespace Services.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
           
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EventConfiguration());
        }



    }
}
