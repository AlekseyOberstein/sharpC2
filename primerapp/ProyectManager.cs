
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerapp
{
    internal class ProyectManager : Employee
    {
        public ProyectManager(string id, string name, double salary) : base(id, name, salary)  {
        
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} Is managing the proyect");
        }
    }
}
