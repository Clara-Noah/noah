using System;

public class PrimeiroPrograma
{
    
    public static void Main (string[] args)
    {
       
        int valor1 = 7;
        int valor2 = 5;

        int soma = valor1 + valor2;
        int subtracao = valor1 - valor2;
        int multiplicacao = valor1 * valor2;
        int divisao = valor1 / valor2;
        int resto = valor1 % valor2;

        Console.WriteLine("A soma é igual a " + soma);
        Console.WriteLine("subtracao = {0}", subtracao);
        Console.WriteLine("multiplicacao = " + multiplicacao);
        Console.WriteLine("divisao = {0}", divisao);
        Console.WriteLine("resto = " + resto);

    }
        
    
}
