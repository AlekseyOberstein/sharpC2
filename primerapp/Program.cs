// See https://aka.ms/new-console-template for more information
using primerapp;



internal class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello, World!")
        FinancialCalculator financialCalculator = new FinancialCalculator(12.45, 2.456, 4, 15); //instancia de la clase
         double interest = financialCalculator.calculateCompundInteres();
          Console.WriteLine(interest.ToString());


           Employee employee = new Employee("","",22);
           Employee employee1 = new Developer("1SX", "Susan", 23000,"C#");    
           Employee employee2 = new ProyectManager("1AX", "John", 13000);

           employee1.Work();
           employee2.Work();

           Computer.CheckList(); //Llamar un método estático

           */

        //definiendo una clase interfaz

        IPaymentMethod paymentCreditCard = new CreditCard(); //es necesario que sea una subclase de la interfaz

        paymentCreditCard.ProcessPayment(4533); //principios solid

        IPaymentMethod paymentBankTransfer = new BankTransfer();

        paymentBankTransfer.ProcessPayment(5444);

    }





}