using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class ProductB : IProduct
    {
        public void doStuff()
        {
            Console.WriteLine("Haciendo algo producto B");
        }
    }
}
