using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerapp
{
    internal interface IPaymentMethod //las interfaces empeizan con la i latina, además en vez de definirla como clase se define como interface
    {

        bool ProcessPayment(decimal amount); //metodo sin modificador de acceso

        //La diferencia entre una clase abstracta y una interfaz es que podemos implementar modificadores de acceso a las interfaces pero no a las abstractas




    }
}
