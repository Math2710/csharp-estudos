using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Operadores_Aritmeticos
{
    internal class Exercicio1
    {
        public static void Executar()
        {
            int x = 17, y = 5;
            Console.WriteLine($"Primeiro número: {x}");
            Console.WriteLine($"Segundoo número: {y}");
            Console.WriteLine("");
            Console.WriteLine($"Soma: {x + y}");
            Console.WriteLine($"Subtração: {x - y}");
            Console.WriteLine($"Multiplicação: {x * y}");
            Console.WriteLine($"Divisão: {x / y}");
            Console.WriteLine($"Módulo: {x % y}");
        }
    }
    internal class Exercicio2
    {
        public static void Executar()
        {
            String num = "150";
            int convertido = Int32.Parse( num );
            int num2 = 30;
            Console.WriteLine($"{num} + {num2} = {convertido + num2}");
            Console.WriteLine($"{num} / {num2} = {convertido / num2}");
        }
    }
    internal class Exercicio3
    {
        public static void Executar()
        {
            String num1 = "89";
            double taxa = 1.5;
            Char categoria = 'B';
            int preco = Int32.Parse(num1);
            double precoFinal = preco * taxa;

            Console.WriteLine($"Preço base: {preco}");
            Console.WriteLine($"Taxa: {taxa}");
            Console.WriteLine($"Preço final: {precoFinal}");
            Console.WriteLine($"Categoria: {categoria}");

        }
    }
}
