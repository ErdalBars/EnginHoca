using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void add(Product product)
        {
            Console.WriteLine(product.ProducName+"Eklendi");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProducName + "Güncellendi");
        }
       
    }
}
