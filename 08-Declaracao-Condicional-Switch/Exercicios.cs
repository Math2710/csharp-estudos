using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Declaracao_Condicional_Switch
{
    internal class Exercicio1
    {
        public static void Executar()
        {
            string bebida = "";
            Console.WriteLine("Digite o tamanho (1 a 3): ");
            int tamanho = int.Parse(Console.ReadLine());

            switch (tamanho)
            {
                case 1:
                    bebida = "Pequena";
                    break;
                case 2:
                    bebida = "Média";
                    break;
                case 3:
                    bebida = "Grande";
                    break;
                default:
                    Console.WriteLine("tamanho inválido");
                    return;
            }
            Console.WriteLine($"bebida {bebida}");
        }
    }
    internal class Exercicio2
    {
        public static void Executar()
        {
            String estacao = "";
            Console.WriteLine("Digite um mes (1 a 12): ");
            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                case 2:
                case 3:
                    estacao = "primavera";
                    break;
                case 4:
                case 5:
                case 6:
                    estacao = "verão";
                    break;
                case 7:
                case 8:
                case 9:
                    estacao = "outono";
                    break;
                case 10:
                case 11:
                case 12:
                    estacao = "inverno";
                    break;
                default:
                    Console.WriteLine("Mês inválido");
                    return;
            }
            Console.WriteLine("Esse mês está na estação de " + estacao);
        }
    }
    internal class Exercicio3
    {
        public static void Executar()
        {
            int resultado;
            string operacao = "";
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digit o operador: (+, -, *, /): ");
            string sinal = Console.ReadLine();
            switch (sinal)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    Console.WriteLine("operador inválido");
                    return;
            }
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
