using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva uma rotina capaz de calcular e apresentar o valor do volume de uma lata de óleo, utilize a fórmula abaixo. 
            V = pi*r2*A
            Onde:
	        V = Volume
	        pi= 3
	        R = Raio da circunferência da lata
	        A = Altura da lata
	        OBS: O volume deve ser apresentado com a unidade de medida correto cm3.
            */
            double pi = 3.141592654; double raio = 0; double altura = 0; double volume = 0; double volume2 = 0;
            Console.WriteLine("Informe o raio da circuferência da lata: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura da lata: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = pi * (raio * raio) * altura;
            volume2 = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine($"O volume da lata de óleo é {volume:F2}cm³\n");
            Console.WriteLine($"O volume da lata de óleo é {volume2:F2}cm³");

            Console.ReadLine();
        }
    }
}
