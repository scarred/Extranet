using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.DAL
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("ExtranetDB")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}