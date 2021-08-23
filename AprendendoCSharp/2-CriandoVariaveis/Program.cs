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

            int idade = 19;

            Console.WriteLine("Minha idade é "+idade+" anos");

            idade = 15;
            Console.WriteLine(idade);

            idade += 20;
            Console.WriteLine(idade);

            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();
            
        }
    }
}
