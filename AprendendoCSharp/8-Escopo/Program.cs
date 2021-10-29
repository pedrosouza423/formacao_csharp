using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool acompanhado = true;
            string nome;

            if (acompanhado)
            {
                nome = "Pedro";
            }
            else
            {
                nome = null;
            }

            Console.WriteLine(nome);

            Console.WriteLine("Para finalizar o programa, tecle enter...");
            Console.ReadLine();
        }
    }
}
