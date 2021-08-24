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
            Console.WriteLine("Executando projeto 4");

            double salario = 1200.5;
            // O int é variavel com 32 bits
            int salarioInteiro = (int)salario;

            Console.WriteLine(salarioInteiro);

            // O short é variavel com 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 150;


            Console.WriteLine(quantidadeProdutos);
            // O short é variavel com 64 bits
            long idadeUniverso = 13000000000;
            
            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
