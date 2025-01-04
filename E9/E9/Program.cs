namespace E9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Desenvolver um programa que apresente e calcule o volume de uma caixa retangular, utilize a fórmula abaixo:
             V=C*L*A
             Onde:
                V=Volume da caixa; C=Comprimento; L=Largura; A=Altura.
             */
            double volume; double comprimento; double largura; double altura;
             
            Console.WriteLine("\nInforme o comprimento da caixa: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a largura da caixa: ");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura da caixa: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = comprimento * largura * altura;

            Console.WriteLine($"O volume da caixa é {volume:F2}cm³");

            Console.ReadLine();

        }
    }
}
