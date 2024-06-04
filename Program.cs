using Lesson_1.Grocery_Machins;
using Lesson_1.ProductRelease;
using Lesson_1.ProductRelease.DrinkRelease;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region authomat_1 init
            HotDrinksMachine authomat_Kirov_street = new HotDrinksMachine();

            authomat_Kirov_street.initProduct(new Chocolate(name:"Темный шоколад c фисташками",cost: 80));
            authomat_Kirov_street.initProduct(new Chocolate(name:"Белый шоколад c кокосом",cost: 76));
            authomat_Kirov_street.initProduct(new Water(name:"Минеральная вода",cost: 30, 60));
            authomat_Kirov_street.initProduct(new FastFood(name: "Бутерброд",cost: 96));
            authomat_Kirov_street.initProduct(new HotDrink(name: "Латте", cost: 70, volume: 80));
            authomat_Kirov_street.initProduct(new HotDrink(name: "Раф", cost: 90, temperature: 60));

            #endregion

            #region authomat_2 init

            HotDrink cupuchino = new HotDrink(name: "Капучино", cost: 65, volume: 70);
            HotDrink mocha = new HotDrink(name: "Мокко", cost: 100, volume: 70);
            Water spring_water = new Water (name: "Ключевая вода", cost: 50, 60);
            HotDrink flat_white = new HotDrink(name: "Флэт уайт", cost: 70, volume: 70);

            HotDrinksMachine authomat_Plekhanov_street = new HotDrinksMachine();

            authomat_Plekhanov_street.initProduct(cupuchino);
            authomat_Plekhanov_street.initProduct(mocha);
            authomat_Plekhanov_street.initProduct(spring_water);
            authomat_Plekhanov_street.initProduct(flat_white);

            #endregion

            #region implement authomat_1

            ShowHomeWork(authomat: authomat_Kirov_street, designation: "один");

            //authomat_Kirov_street.GetProduct("бутерброд");

            #endregion

            #region implement authomat_2

            ShowHomeWork(authomat: authomat_Plekhanov_street, designation: "два");

            //authomat_Plekhanov_street.GetProduct("Ключевая вода");

            #endregion


        }

        public static void ShowHomeWork(HotDrinksMachine authomat, string designation)
        {
            if (authomat.GetNumberOfTypes() == 1) { Console.WriteLine ($"\nТовар в автомате {designation}:"); }

            else if (authomat.GetNumberOfTypes() > 1) { Console.WriteLine ($"\nТовары в автомате {designation}:"); }

            else { Console.WriteLine ($"\nТоваров в автомате нет"); }

            authomat.ShowProducts();
        }
    }
}
