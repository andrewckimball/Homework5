using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Models.ViewModel
{
    //Class to iterate through the Project class
    public class ProjectListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public PageInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
