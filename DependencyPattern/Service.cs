﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyPattern
{
   public class Service:IService
    {
      public void Serve()
        {
            Console.WriteLine("Service Called");
        }
    }
}
