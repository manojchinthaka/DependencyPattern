using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyPattern
{
   public class ClientProperty
    {
        private IService _service;

        public IService service
        {
            set
            {
                this._service = value;
            }
        }


        public void start()
        {
            Console.WriteLine("Service Started");
            _service.Serve();
        }
    }
}
