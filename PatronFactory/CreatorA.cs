using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class CreatorA : Creator
    {
        public override IProduct createProduct()
        {
            Console.WriteLine("Creando Producto A");
            return new ProductA();
            
        }
    }
}
