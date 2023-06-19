using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerapp
{
    internal abstract class Employee //A las clases abstractas se les definen métodos o no que se pueden heredar otras clases
    {

        //Ahora se 
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }


        public Employee(string id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public abstract void Work();
    }
}
