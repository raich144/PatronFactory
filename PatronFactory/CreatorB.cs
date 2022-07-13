using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class CreatorB : Creator
    {
        public override IProduct createProduct()
        {
            Console.WriteLine("Creando Producto B");
            return new ProductB();
            
            
        }
    }
}
