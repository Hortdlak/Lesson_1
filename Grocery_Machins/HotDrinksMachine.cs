using Lesson_1.ProductRelease;
using Lesson_1.ProductRelease.DrinkRelease;

namespace Lesson_1.Grocery_Machins
{
    internal class HotDrinksMachine : IGrocery_Machine
    {
        private List<Product> grosery = [];

        

        public void initProduct(Product product) // AddProductInfo
        {
            if (product is HotDrink) { this.grosery.Add(product); }
        }
        public void initProduct(List<Product> grosery) // DowloadAllProductInfo
        {
            foreach (Product product in grosery) 
            {
                if(product is HotDrink)
                {
                    this.grosery.Add(product);
                }
            }
        }
        public Product FindProduct(string name)
        {
            return grosery.Find(p => p.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public void GetProduct(string product_name)
        {
            var result = FindProduct(product_name);
            if (result != null && result is HotDrink hotDrink)
            {
                Console.WriteLine($"Продукт найден: {product_name}, цена: {result.GetCost()} рублей," +
                        $" объем: {hotDrink.GetVolume()} мл, температура: {hotDrink.GetTemperature()} градусов.");
            }
            else { Console.WriteLine($"Продукт {product_name} не найден"); }
        }
        public void ShowProducts()
        {
            foreach (var product in grosery)
            {
                if (product is HotDrink hotDrink)
                {
                    Console.WriteLine($"Продукт: {product.GetName()}, цена: {product.GetCost()} рублей," +
                        $" объем: {hotDrink.GetVolume()} мл, температура: {hotDrink.GetTemperature()} градусов.");
                }
            }
        }

        public int GetNumberOfTypes() { return grosery.Count; }


    }
}
