using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyPattern
{
   public class ClientMethod
    {
        private IService _service;

        public void Start(IService service)
        {
            this._service = service;
            Console.WriteLine("Service Started");
            this._service.Serve();
        }
    }
}
