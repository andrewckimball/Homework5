using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Models
{
    public class ProjectDbContext : DbContext  //Inherits from DbConext in system
    {
        //Constructor when instance of object is built the first time
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
