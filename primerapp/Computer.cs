using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerapp
{
    internal class Computer // Este es un método estático
    {

        public string Name { get; set; }
        public bool IsRunning { get; set; }
        public string IpAddress { get; set; }

        public static void CheckList()
        {

            List<Computer> computers = new List<Computer>()
            {
                new Computer{Name = "Server", IsRunning = true, IpAddress = "192.168.0.1" },
                new Computer{Name = "WS1", IsRunning = true, IpAddress = "192.168.0.2" },
                new Computer{Name = "WS2", IsRunning = false, IpAddress = "192.168.0.3" },
                new Computer{Name = "WS3", IsRunning = true, IpAddress = "192.168.0.4" }

            };

            foreach (Computer computer in computers)
            {
                if (computer.IsRunning)
                    Console.WriteLine($"{computer.Name} is online with ip {computer.IpAddress}.");
                else
                    Console.WriteLine($"{computer.Name} is online offline");


            }

        }
    }
}
