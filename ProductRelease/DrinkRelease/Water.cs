using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.ProductRelease.DrinkRelease
{
    internal class Water : Drink
    {
        public Water() { }
        public Water(string name, int cost, int volume) : base(name, cost, volume)
        {
        }
    }
}
