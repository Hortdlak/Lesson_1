using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.ProductRelease
{
    internal class Chocolate : Product
    {
        public Chocolate() { }
        public Chocolate(string name, int cost) : base(name, cost)
        {
        }
    }
}
