using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyPattern
{
   public class ClientConstructor
    {
        private IService _service;

        public ClientConstructor(IService service )
        {
            _service = service;
        }

        public void start()
        {
            Console.WriteLine("Service Started");
            _service.Serve();
        }
    }
}
