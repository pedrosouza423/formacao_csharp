using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuiçõesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 25;
            int idadePedro = idade;

            idade += 5;

            Console.WriteLine(idadePedro);


            Console.WriteLine("Para finalizar o programa, tecle enter...");
            Console.ReadLine();
        }
    }
}
