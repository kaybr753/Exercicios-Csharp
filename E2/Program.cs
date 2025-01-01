using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Baseado nas fórmulas abaixo, desenvolva uma rotina que calcule o salário líquido de um funcionário. 
            Após o cálculo o programa deve apresentar o salário base e o salário líquido calculado.
            SB =  Salário Base/HT = Horas Trabalhadas/VH = Valor Hora de trabalho/TD = Total de Descontos/PD = Percentual de Desconto
            SL = Salário Líquido
            SB = HT * VH/ TD = (PD / 100) * SB/SL = SB  - TD
             */
            Console.Title = "Calculadora de Salário";
            double salarioBase = 0;int horasTrabalhada = 0; double valordaHoraDeTrabalho = 0; 
            double totalDeDesconto = 0; double percentualDeDesconto = 0; double salarioLiquido = 0;


            Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
            horasTrabalhada = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor da hora de trabalho: ");
            valordaHoraDeTrabalho = Convert.ToDouble(Console.ReadLine());
            salarioBase = horasTrabalhada * valordaHoraDeTrabalho;
            Console.WriteLine($"O seu salário base é R${salarioBase:F2}");


            Console.WriteLine("Informe o percentual de desconto em %: ");
            percentualDeDesconto = Convert.ToDouble(Console.ReadLine());
            totalDeDesconto = ((percentualDeDesconto/100)*salarioBase);
            Console.WriteLine($"Você terá um desconto de R${totalDeDesconto:F2} do seu salário");

            salarioLiquido = (salarioBase - totalDeDesconto);
            Console.WriteLine($"Seu salário de R${salarioBase} teve um desconto de {percentualDeDesconto}% seu novo salário é R${salarioLiquido}");
        }
    }
}
