using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.E3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que realize a conversão de graus Celsius
             (C)  para graus Fahrenheit (F). Utilize a fórmula abaixo:
            F = ((Celius * 1.8)+ 32)
            */
            Console.Title = "Conversor de Graus Celsius para Fahrenheit";
            double grausCelsius = 0; double grausFahrenheit = 0;

            Console.WriteLine("Informe a temperatura em graus Celsius: ");
            grausCelsius = Convert.ToDouble(Console.ReadLine());


            grausFahrenheit = ((grausCelsius * 1.8) + 32);
            Console.WriteLine($"A temperatura {grausCelsius}° em fahrenheit é {grausFahrenheit}");
        }
    }
}
