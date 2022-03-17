using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models; 


namespace WebAPI.Models
{
    public class FirstAppDempContext : DbContext
    {
        public FirstAppDempContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }
    }

}
