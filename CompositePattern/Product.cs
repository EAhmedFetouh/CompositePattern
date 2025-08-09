using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Product : ICartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal GetPrice() => Price;


        public void Print(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}Product: {Name} - {GetPrice()}");
        }
    }
}
