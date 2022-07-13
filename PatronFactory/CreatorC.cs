﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory
{
    public class CreatorC : Creator
    {
        public override IProduct createProduct()
        {
            Console.WriteLine("Creando producto C");
            return new ProductC();
        }
    }
}
