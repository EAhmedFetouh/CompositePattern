using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class GiftItem : ICartItem
    {
        public string Name { get; set; }

        public decimal GetPrice() => 0;

        public void Print(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}GiftItem: {Name} - 0");
        }
    }
}
