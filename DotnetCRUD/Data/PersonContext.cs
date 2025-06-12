using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DotnetCRUD.Models;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCRUD.Data
{
    public class PersonContext : DbContext
    {
        public DbSet<PersonModel> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(connectionString: "Data Source=person.sqlite");
        }
    }
}
