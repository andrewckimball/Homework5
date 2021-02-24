using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Models.ViewModel
{
    //Creating PageInfo class to keep track of number of pages and items per page
    public class PageInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
