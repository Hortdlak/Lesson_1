using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.ProductRelease
{
    internal class Drink: Product
    {
        protected int Volume { get; set; }

        public Drink() { }
        public Drink(string name, int cost, int volume=60) : base(name, cost)
        {
            Volume = volume;
        }

        public int GetVolume() => this.Volume;
    }
}
