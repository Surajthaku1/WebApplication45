using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication45.Model
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext() : base("Data Source=CHETUIWK988\\SQLSERVER;Initial Catalog=Employeedb;Integrated Security=True;Pooling=False") { }

        public DbSet<employee> employees { get; set; }
    }
}