using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _10_Estruturas_De_Repeticao_While
{
    internal class Exercicio1
    {
        public static void Executar()
        {
            int senha = 1234;
            int tentativas = 0;
            int digitado;
            do
            {
                Console.Write("Digite a senha: ");
                digitado = int.Parse(Console.ReadLine());
                ++tentativas;
                if (digitado != senha)
                {
                    Console.WriteLine("Senha incorreta! Tente novamente.");
                }
            }
            while (digitado != senha);
            Console.WriteLine("Acesso permitido!");
            Console.WriteLine("Total de tentativas: {0}", tentativas);

        }
    }
    internal class Exercicio2
    {
        public static void Executar()
        {
            double saldo = 1000.00;
            int opcao;
            double deposito;
            double saque;
            do
            {
                Console.Write("===== CAIXA ELETRÔNICO =====\r\n\r\n" +
                    "1 - Consultar saldo\r\n" +
                    "2 - Depositar\r\n" +
                    "3 - Sacar\r\n" +
                    "4 - Sair\r\n\r\n" +
                    "Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Saldo atual: R$ {0}", saldo, "\n\n");

                }
                else if (opcao == 2)
                {
                    Console.WriteLine("");
                    Console.Write("Digite o valor do depósito: ");

                    deposito = double.Parse(Console.ReadLine());
                    saldo += deposito;
                    Console.Write("\nDepósito realizado!\r\n" +
                        $"Saldo atual: R$ {saldo}\n\n"
                        );

                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o valor do saque: R$");
                    saque = double.Parse(Console.ReadLine());
                    saldo -= saque;
                    Console.WriteLine("");
                    Console.WriteLine("Saque realizado!");
                    Console.WriteLine($"Saldo atual: R$ {saldo}\n\n");

                }
                else if (opcao == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Obrigado por utilizar nosso caixa eletrônico!");
                    break;
                }
                else
                {
                    Console.WriteLine("Digite uma opção válida!\n");
                }

            }
            while (true);
            {

            }
        }
    }
    internal class Exercicio3
    {
        public static void Executar()
        {
            Random secreto = new Random();
            int numAleatorio = secreto.Next(0, 101);
            int palpite;
            int tentativas = 0;
            Console.WriteLine("===== JOGO DE ADIVINHAÇÃO =====\r\n\r\n" +
                    "Tente descobrir o número entre 1 e 100!\r\n");
            do
            {
                Console.Write("Digite seu palpite: ");
                palpite = int.Parse(Console.ReadLine());
                if (palpite < 1 || palpite > 100)
                {
                    Console.WriteLine("São válidos somente números de 1 a 100!\n\n");
                }
                else if (palpite < numAleatorio)
                {
                    Console.WriteLine("O número secreto é maior!\n\n");
                    tentativas++;
                }
                else if (palpite > numAleatorio)
                {
                    Console.WriteLine("O número secreto é menor!\n\n");
                    tentativas++;
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou!\r\n\n");
                    Console.WriteLine($"Números de tentativas: {tentativas}");
                    break;
                }
            }
            while (true);
        }
    }
}
