using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerapp
{
    internal class FinancialCalculator
    {
        //Variables privadas (Atributos) Encapsulamiento
        private double principal;
        private double rate;
        private int timesCompunded;
        private int years; 

        //Constructor clase

        public FinancialCalculator(double principal, double rate, int timesCompunded, int years)
        {
            this.principal = principal;
            this.rate = rate;
            this.timesCompunded = timesCompunded;
            this.years = years; 

        }

        //Propiedades de la clase - Elementos publicos para obtener y establecer las variables privadas

        public double Principal { get { return principal; } set { principal = value; } }

        public double Rate { get { return rate; } set { rate = value; } }

        public int TimesCompunded { get { return timesCompunded; } set { timesCompunded = value; } }

        public int Years { get { return years; } set { years = value; } }


        //Método para calcular el intéres compuesto

        public double calculateCompundInteres()
        {

            //A = P(1 + r/n)^(nt)
            //Cuando se usa .NET ya tienes unas bibliotecas instaladas

            return Principal * Math.Pow((1+Rate / TimesCompunded), timesCompunded*Years);

        }

    }
}
