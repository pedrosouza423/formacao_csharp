using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7");

            int idade = 16;
            int quantidadePessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade. Pode entrar");
            }
            else if(idade >=16 && quantidadePessoas > 1)
            {
                Console.WriteLine("Você é menor de idade. Mas está acompanhado");

            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }


            Console.WriteLine("Tecle enter para sair");
            Console.ReadLine();
        }
    }
}
