using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Models.ViewModel
{
    public class ProjectListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public PageInfo PagingInfo { get; set; }
    }
}
