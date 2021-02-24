using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Models
{
    public class SeedData
    {
        //Seeding database with the provided data in instructions
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            ProjectDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<ProjectDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Projects.Any())
            {
                context.Projects.AddRange(

                    //Entering new data with the properties in the project.cs file
                    new Project
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Vicor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95m,
                        NumberOfPages = 1488
                    },

                    new Project
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58m,
                        NumberOfPages = 944
                    },

                    new Project
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54m,
                        NumberOfPages = 832
                    },

                    new Project
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61m,
                        NumberOfPages = 864
                    },

                    new Project
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33m,
                        NumberOfPages = 528
                    },

                    new Project
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95m,
                        NumberOfPages = 288
                    },

                    new Project
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99m,
                        NumberOfPages = 304
                    },

                    new Project
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 21.66m,
                        NumberOfPages = 240
                    },

                    new Project
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16m,
                        NumberOfPages = 400
                    },

                    new Project
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03m,
                        NumberOfPages = 642
                    },

                    //Three of my favorite books
                    new Project
                    {
                        Title = "Sapiens",
                        AuthorFirst = "Yuval",
                        AuthorLast = "Harari",
                        Publisher = "Dvir Publishing House",
                        ISBN = "978-0062316097",
                        Classification = "Non-Fiction",
                        Category = "History",
                        Price = 13.42m,
                        NumberOfPages = 443
                    },

                    new Project
                    {
                        Title = "Waking Up",
                        AuthorFirst = "Sam",
                        AuthorLast = "Harris",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-1451636017",
                        Classification = "Non-Fiction",
                        Category = "History",
                        Price = 10.50m,
                        NumberOfPages = 256
                    },

                    new Project
                    {
                        Title = "Homo Deus",
                        AuthorFirst = "Yuval",
                        AuthorLast = "Harari",
                        Publisher = "Harvill Secker",
                        ISBN = "978-1910701874",
                        Classification = "Non-Fiction",
                        Category = "History",
                        Price = 12.81m,
                        NumberOfPages = 464
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
