using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Efetuar o cálculo de quantos litros de combustível um automóvel consome em uma viagem. 
            Sabendo que o automóvel tem uma autonomia de 12 Km por litro de combustível, 
            desenvolva o cálculo utilizando a fórmula abaixo:
            D=T*V
            LU=D/12
            Onde: D = Distância em Km/T = Tempo gasto na viagem/V = Velocidade
             */
            double distância = 0; double tempo = 0; double velocidade = 0;
            double litrosUsado = 0;
            //Achar o valor da distância

            //Perguntar ao usuario quanto tempo ele gastou na viagem (horas viajada) e armazenar a informação na variavel tempo.
            Console.WriteLine("Quanto tempo você gastou na viagem: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            //Perguntar ao usuario qual foi sua velocidade média durante a viagem(km/h) e armazenar a informação na variavel tempo.
            Console.WriteLine("Qual foi sua velocidade média: ");
            velocidade = Convert.ToDouble(Console.ReadLine());

            //Calcular a distancia, usando o tempo versus velocidade, equação básica de física/cinemática
            distância = tempo * velocidade;
            Console.WriteLine($"A distância ate o destino final é: {distância:F2} KM");//:F2 usado para definir uma aproximação decimal de 2 números apos virgula

            //Achar a quantidade de combustível gasto

            litrosUsado = distância / 12;
            Console.WriteLine($"A quantidade de combustível gasto na viagem foi de {litrosUsado:F2} Litros");
        }
    }
}
