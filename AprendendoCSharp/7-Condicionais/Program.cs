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
            int idadePedro = 16;
            bool acompanhado = true;

            if (idadePedro >=18 && acompanhado)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.WriteLine("Para finalizar o programa, tecle enter...");
            Console.ReadLine();
        }
    }
}
