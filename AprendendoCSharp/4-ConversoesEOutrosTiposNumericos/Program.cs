using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1500.5;
            int salarioInt = (int)salario;

            //Numeros acima de 2 bilhões use o tipo long
            //shor é uma quantidade de numero pequeno

            Console.WriteLine("Para finalizar o programa, tecle enter...");
            Console.ReadLine();
        }
    }
}
