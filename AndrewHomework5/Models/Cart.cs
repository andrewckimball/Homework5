using AndrewHomework5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        //Virtual reference to override the members
        public virtual void AddItem(Project proj, int qty)
        {
            CartLine line = Lines
                .Where(p => p.Project.ProjectId == proj.ProjectId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Project = proj,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        //Virtual reference to remove books
        public virtual void RemoveLine(Project proj) =>
            Lines.RemoveAll(x => x.Project.ProjectId == proj.ProjectId);

        public virtual void Clear() => Lines.Clear();

        //Method to compute the sum of the individual books
        public decimal ComputeTotalSum()
        {
            return Lines.Sum(e => e.Project.Price * e.Quantity);
        }

        //Creating CartLine class
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Project Project { get; set; }
            public int Quantity { get; set; }
        }

    }
}

