using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HCLPaasCoe.Models
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext (DbContextOptions<EmployeesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<HCLPaasCoe.Models.Employee> Employee { get; set; }
    }
}
