namespace employeeCrud.Models
{
 
    using employeeCrud.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;


    public class CompanyContext
        : DbContext
    {
        public CompanyContext(DbContextOptions options)
        : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
