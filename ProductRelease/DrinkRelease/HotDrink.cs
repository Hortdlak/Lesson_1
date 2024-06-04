using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1.ProductRelease.DrinkRelease
{
    internal class HotDrink : Drink
    {
        protected int Temperature { get; set; }
        public HotDrink() { }
        public HotDrink(string name, int cost, int volume = 60, int temperature=90) : base(name, cost, volume)
        {
            this.Temperature = temperature;
        }
        public int GetTemperature() => this.Temperature;

    }
}
