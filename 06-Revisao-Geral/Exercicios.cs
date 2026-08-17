using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace _06_Revisao_Geral
{
    internal class Exercicio1
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o primeiro número:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            float num2 = float.Parse(Console.ReadLine());

            float soma = num1 + num2;
            float multiplicacao = num1 * num2;
            float media = soma / 2;

            Console.WriteLine($"Soma: {soma:F2}\nmultiplicação: {multiplicacao:F2}\nMédia: {media:F2}");
        }
    }
    internal class Exercicio2
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o valor do depósito: ");
            int saldo = int.Parse(Console.ReadLine());
            if (saldo < 100)
            {
                Console.WriteLine("Saldo Baixo");
            }
            else if (saldo > 100 || saldo < 500)
            {
                Console.WriteLine("Saldo médio");
            }
            else
            {
                Console.WriteLine("Saldo alto");
            }
        }
    }
    internal class Exercicio3
    {
        public static void Executar()
        {
            String produto = "Mouse";
            char categoria = 'M';
            int estoque = 5;
            Console.WriteLine("Quantas unidades deseja comprar? ");
            int qtdComprada = int.Parse(Console.ReadLine());
            estoque -= qtdComprada;
            if (qtdComprada > 5)

            {
                Console.WriteLine("Estoque insuficiente!");
            }
            else
            {
                Console.WriteLine(
                    $"Produto: {produto}\n" +
                    $"Categoria: {categoria}\n" +
                    $"Estoque restante: {estoque}");
            }
        }
    }
}
