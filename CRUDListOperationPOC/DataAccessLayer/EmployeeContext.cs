using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using CRUDListOperationPOC.Models;

namespace CRUDListOperationPOC.DataAccessLayer
{
    public class EmployeeContext : DbContext 
    {
        public EmployeeContext() : base("EmployeeContext")
        {
        }

        public DbSet<EmployeeDetails > Employees { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}