using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Calcular e apresentar o valor de uma prestação em atraso, utilize a fórmula abaixo:
            P=VALOR + (VALOR * (TAXA/100)*TEMPO)
            Onde P é o valor da prestação em atraso.
            valor é o preço do produto// tempo é a quantidade de dias em atraso
             */
            double valor = 0; double taxa = 0; double tempo = 0; double p = 0;
            Console.ReadKey();

            //Pergunta ao usuario o valor do produto

            Console.WriteLine("Qual o valor do produto: ");
            valor = Convert.ToDouble(Console.ReadLine());

            //Pergunta ao usuario o valor a taxa em %

            Console.WriteLine("Qual o valor da porcentagem %: ");
            taxa = Convert.ToDouble(Console.ReadLine());


            //Pergunta ao usuario a quantidade de dias em atraso

            Console.WriteLine("Quantos dias está em atraso: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            //Valor da prestação em atraso

            p = (valor + (valor * (taxa / 100) * tempo));

            Console.WriteLine($"O valor da prestação em atraso é de R${p:F2}");

        }
    }
}
