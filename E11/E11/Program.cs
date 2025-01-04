namespace E11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Elaborar um programa que realize a conversão de US$ para R$, o 
            programa deve saber qual o valor da cotação do dólar e fazer a conversão.
             */
            decimal dolar, conversãoReal, cotaçãoDolar;
            Console.WriteLine("Informe a cotação do dolár: ");
            cotaçãoDolar = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de dolares que você quer converter: ");
            dolar = Convert.ToDecimal(Console.ReadLine());

            conversãoReal = dolar * cotaçãoDolar;

            Console.WriteLine($"Você converteu U${dolar:F2} em R${conversãoReal:F2}");
        }
    }
}
