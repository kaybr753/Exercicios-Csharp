using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.E4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escreva um programa que realize a conversão de graus Fahrenheit (F)  para graus Celsius (C). 
            Utilize a fórmula abaixo:
            C = (( F - 32) * 5)/9
             */
            double grausFahrenheit = 0; double grausCelsius = 0;
            Console.WriteLine("Informe a temperatura em graus Fahrenheit: ");
            grausFahrenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            grausCelsius = (((grausFahrenheit - 32)*5)/9);
            Console.WriteLine($"{grausFahrenheit} graus Fahrenheit em graus celsius é {grausCelsius:F2}° celsius");

            Console.ReadLine();
        }
    }
}
