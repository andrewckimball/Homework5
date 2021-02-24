using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Models
{
    //Moedl for the bookstore and the associated database
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        
        //All fields are required
        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirst { get; set; }

        [Required]
        public string AuthorLast { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}[-]\d{10}$", ErrorMessage = "Please enter valid ISBN number")] //Validation for ISBN number
        public string ISBN { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int NumberOfPages { get; set; }  //Additional data to the model for assignment 6

    }
}
