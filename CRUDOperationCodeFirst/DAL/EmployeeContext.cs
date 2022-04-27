using CRUDOperationCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CRUDOperationCodeFirst.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
            : base("EmployeeContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}