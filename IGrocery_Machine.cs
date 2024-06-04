using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_1
{
    interface IGrocery_Machine
    {
        public void initProduct(Product product);
        public void initProduct(List<Product> grosery);

        Product FindProduct(string name);
        public void GetProduct(string product_name);
        public void ShowProducts();

        public int GetNumberOfTypes();

    }
}
