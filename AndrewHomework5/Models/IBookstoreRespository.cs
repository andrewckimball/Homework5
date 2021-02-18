using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Models
{
    //Repository provides way to access the features in the database context class
    public interface IBookstoreRespository
    {
        IQueryable<Project> Projects { get; }

    }
}
