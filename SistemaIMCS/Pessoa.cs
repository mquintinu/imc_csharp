using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaIMC
{
    class Pessoa
    {
        public double peso, altura;      

        // Calcula IMC
        public double CalculaIMC(double peso, double altura)
        {
            return peso / (altura * altura);           
        }

        public void RetornaIMC()
        {
            double imc = CalculaIMC(peso, altura);
            Console.WriteLine("Seu IMS é de: " + Math.Round(imc, 2));
            if (imc <= 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc <= 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc <= 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc <= 35)
            {
                Console.WriteLine("Obesidade I");
            }
            else if (imc <= 40)
            {
                Console.WriteLine("Obesidade II");
            }
            else
            {
                Console.WriteLine("Obsedidade III");
            }
        }

    }
}
