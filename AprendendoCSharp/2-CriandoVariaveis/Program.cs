using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");
            int idade = 20;
            string nome = "Pedro";
            idade += 15;
            Console.WriteLine("O meu nome é "+nome + " e minha idade é "+idade);


            Console.WriteLine("Para finalizar o programa, tecle enter...");
            Console.ReadLine();
        }
    }
}
