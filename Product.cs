using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    internal abstract class Product
    {
        protected int Cost {  get; set; }
        protected string? Name { get; }

        public Product() { }
        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        public string? GetName() => this.Name;
        public int GetCost() => this.Cost;
    }
}
