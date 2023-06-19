using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerapp
{
    internal class Developer : Employee
    {

        public string PreferredLanguage { get; set; }

        public Developer(string id, string name, double salary, string preferredLanguage) : base (id, name, salary)
        {

            PreferredLanguage = preferredLanguage;

        }

        public override void Work()
        {
            Console.WriteLine($"{Name} IServiceProvider coding in {PreferredLanguage}");
        }
    }
}
