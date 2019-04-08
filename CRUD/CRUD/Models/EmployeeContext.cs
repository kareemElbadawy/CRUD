using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
           : base("name=MySqlConnection")
        {
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}