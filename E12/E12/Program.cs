/*
Elaborar um programa que realize a conversão de R$ para US$, 
o programa deve saber qual o valor da cotação do dólar e fazer a conversão.
*/
decimal taxaCambial, valorDolar, valorReal;
Console.Title = "Conversão de R$ para US$\n";

Console.WriteLine("Informe  o valor em R$: ");
valorReal = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe a taxa cambial: ");
taxaCambial = Convert.ToDecimal(Console.ReadLine());

valorDolar = valorReal / taxaCambial;
Console.WriteLine();

Console.WriteLine($"O valor em US$ é: {valorDolar:F2}");

Console.ReadKey();

