using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebAPI.Models
{
    public class FirstAppDempDbContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
    }

}
