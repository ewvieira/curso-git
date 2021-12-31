using System;
using System.Globalization;

namespace testeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1}", produto1, preco1.ToString("F2"));
            Console.WriteLine("{0}, cujo preço é $ {1}", produto2, preco2.ToString("F2"));
            Console.WriteLine("Registro: {0} anos de idade, codigo {1} e genero: {2}", idade, codigo, genero);
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F2", CultureInfo.InvariantCulture));



            Triangulo t, u;
            t = new Triangulo();
            u = new Triangulo();

            t.A = 10.00;
            t.B = 5.00;
            t.C = 7.00;

            u.A = 10.00;    
            u.B = 5.00;
            u.C = 7.00;

            double areaT = t.Area();
            double areaU = u.Area();

            Console.WriteLine(areaT);
            Console.WriteLine(areaU);
            */

            Console.WriteLine(Calculadora.Circunferencia(5));
            Console.WriteLine(Calculadora.Volume(8));
            TimeSpan t1 = TimeSpan.FromMilliseconds(500);
            Console.WriteLine(t1);
            DateTime t2 = new DateTime(2021, 12, 31, 23, 59, 59);
            Console.WriteLine(t2.DayOfYear);
            Console.WriteLine(t2.DayOfWeek);
            Console.WriteLine(t2.Kind);
            Console.WriteLine(t2.Ticks);
            Console.WriteLine(t2.TimeOfDay);



        }
    }
}
