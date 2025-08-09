using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public interface ICartItem
    {
        decimal GetPrice();

        void Print(int indent = 0);
    }
}
