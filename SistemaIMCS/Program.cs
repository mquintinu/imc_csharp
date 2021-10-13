using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.altura = 1.69;
            pessoa.peso = 84;

            pessoa.CalculaIMC(pessoa.peso, pessoa.altura);
            pessoa.RetornaIMC();
            Console.ReadLine();
        }
    }
}
