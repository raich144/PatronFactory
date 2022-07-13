using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public abstract class  Creator
    {
        public abstract IProduct createProduct();

        public  void someOperacion()
        {
            Console.WriteLine("Operación en Creator");
            IProduct p = createProduct();
            p.doStuff();
        }
        

    }
}
