using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text;

namespace _05_Estruturas_Decisao_Condicional_Simples_Composta
{
    internal class Exercicio01
    {
        public static void Executar()
        {
            int num;
            Console.WriteLine("Digite um número: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("O número é positivo!");
            }
            else
            {
                Console.WriteLine("O número é negativo");
            }
        }
    }
    internal class Exercicio02
    {
        public static void Executar()
        {
            int num1;
            int num2;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            Console.WriteLine($"A soma dos dois números é {soma}");
            if (soma > 20)
            {
                Console.WriteLine("A soma é maior que 20");
            }
            else
            {
                Console.WriteLine("A soma é menor do que 20");
            }
        }
    }
    internal class Exercicio03
    {
        public static void Executar()
        {
            int senhaCorreta = 1234;
            int tentativas = 0;
            int senha;

            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());
            tentativas++;

            if (senha == senhaCorreta)
            {
                Console.WriteLine("Acesso liberado");
            }
            while(senha != senhaCorreta)
            {
                Console.WriteLine($"Acesso negado.\nTentativas: {tentativas}");
                Console.WriteLine("");
                Console.WriteLine("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
                tentativas++;
                if (senha == senhaCorreta)
                {
                    Console.WriteLine("Acesso liberado");
                }

            }
        }
    }
}