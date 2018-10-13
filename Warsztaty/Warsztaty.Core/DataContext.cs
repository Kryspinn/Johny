using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Warsztaty.Core
{
    class DataContext: DbContext
    {
        public virtual DbSet<ContactModel> Contact { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CodeAndCloud;Trusted_Connection=true;");
            optionsBuilder.UseSqlServer(@"Server=tcp:johny4.database.windows.net,1433;Initial Catalog=johny4-db;Persist Security Info=False;User ID=Kryspinn;Password=Ola-1705;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
