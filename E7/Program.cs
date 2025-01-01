using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ler valores para as variáveis x e y, trocar os valores das variáveis e apresentar o resultado dos valores invertidos.
             */
            int x, y, z;
            Console.WriteLine("Escolha um número: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha um segundo número: ");
            y = Convert.ToInt32(Console.ReadLine());

            //Trocar o valor de x y, ou seja x = y e y = x;

            z = x;
            x = y;
            y = z;
            Console.WriteLine($"O valor de x trocado é {x}");
            Console.WriteLine($"O valor de y trocado é {y}");
        }
    }
}
