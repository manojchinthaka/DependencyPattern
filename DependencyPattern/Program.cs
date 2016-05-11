using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor injectinon
            ClientConstructor serviceConstructorClient = new ClientConstructor(new Service());
            serviceConstructorClient.start();

            //Property Injection
            ClientProperty servicePropertyclient = new ClientProperty();
            servicePropertyclient.service = new Service();
            servicePropertyclient.start();

            //Method Injection
            ClientMethod serviceMethodClient = new ClientMethod();
            serviceMethodClient.Start(new Service());
           

        }
    }
}
