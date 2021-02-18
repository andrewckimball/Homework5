using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Models
{
    //Entity framework for bookstore repository 
    public class EFBookstoreRepository : IBookstoreRespository
    {
        private ProjectDbContext _context;

        public EFBookstoreRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public IQueryable<Project> Projects => _context.Projects;
    }
}
