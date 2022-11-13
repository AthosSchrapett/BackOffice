using BackOfficeApi.Model.Entities.Person;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackOfficeApi.Data
{
    public class BackOfficeContext : DbContext
    {
        public BackOfficeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LegalPerson> LegalPersons { get; set; }
        public DbSet<NaturalPerson> NaturalPersons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
