namespace E10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer a leitura de um valor numérico inteiro e apresentar o valor do número elevado ao quadrado
            ao cubo e a 10, apresentar também a soma total dos três resultados anteriores.
             */
            int num1;

            Console.WriteLine("Digite um número inteiro: ");
            num1 = (int)Convert.ToInt64(Console.ReadLine());

            Console.WriteLine();

            long quadrado = (long)Math.Pow(num1, 2);
            long cubo = (long)Math.Pow(num1, 3);
            long decima = (long)Math.Pow(num1, 10);

            Console.WriteLine($"{num1} ao quadrado é {quadrado}\n");
            Console.WriteLine($"{num1} ao cubo é {cubo}\n");
            Console.WriteLine($"{num1} a decima é {decima}\n");

            Console.WriteLine($"A soma de {quadrado} {cubo} {decima} vale {quadrado + cubo + decima}");

            //Console.WriteLine($"{num1} ao quadrado é {Math.Pow(num1, 2)}");
            //Console.WriteLine($"{num1} ao cubo é {Math.Pow(num1, 3)}");
            //Console.WriteLine($"{num1} a decima é {Math.Pow(num1, 10)}");

            //Console.WriteLine(Math.Pow(num1, 2) + Math.Pow(num1, 3) + Math.Pow(num1, 10));

            Console.ReadLine();
        }
    }
}
