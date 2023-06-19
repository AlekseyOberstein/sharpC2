using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerapp
{
    internal class CreditCard: IPaymentMethod   //En un principio no se está implementando el método
    {

        public bool ProcessPayment(decimal amount) //Es estrictamente necesario definir los métodos de la interfaz de la cual se hereda
        {

            Console.WriteLine($"procesando el pago de {amount} con tarjeta");

            return true;

        }

    }

    internal class BankTransfer : IPaymentMethod
    {

        public bool ProcessPayment(decimal amount) //Es estrictamente necesario definir los métodos de la interfaz de la cual se hereda
        {

            Console.WriteLine($"procesando el pago de {amount} con transferencia bancaria");

            return true;

        }

    }

    internal class Cryptocurrency : IPaymentMethod
    {
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"procesando el pago de {amount} con criptomonedas");

            return true;

        }
    }


    //Todos implementan la misma interfaz, pero se define el método de distinta forma

}



