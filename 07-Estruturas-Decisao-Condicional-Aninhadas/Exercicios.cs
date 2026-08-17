using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Estruturas_Decisao_Condicional_Aninhadas
{
    internal class Exercicio01
    {
        public static void Executar()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int estacao;
            Console.WriteLine("digite um número de 1 a 4\n(representando as estações do ano: 1-Verão, 2-Outono, 3-Inverno, 4-Primavera)");
            estacao = int.Parse(Console.ReadLine());

            if (estacao == 1)
            {
                Console.WriteLine("Verão");
            }
            else if (estacao == 2)
            {
                Console.WriteLine("Outono");
            }
            else if (estacao == 3)
            {
                Console.WriteLine("Inverno");
            }
            else if (estacao == 4)
            {
                Console.WriteLine("Primavera");
            }
            else
            {
                Console.WriteLine("Número não correspondente com as opções, encerrando!");
            }
        }
    }
    internal class Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você tem carteira de motorista? (1-Sim, 2-Não)");
                int opcao = int.Parse(Console.ReadLine());


                while (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("Digite (1-Sim, 2-Não)");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Console.WriteLine("Maior de idade, pode dirigir!");
                    }
                    else if (opcao == 2)
                    {
                        Console.WriteLine("Maior de idade, não pode dirigir, precisa tirar a carteira");
                    }
                }

            }
            else
            {
                Console.WriteLine("Menor de idade, não pode dirigir");
            }
        }
    }
    internal class Exercicio03
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua nota: ");
            int nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de faltas: ");
            int faltas = int.Parse(Console.ReadLine());

            if(nota >= 9)
            {
                Console.WriteLine("Conceito: A");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Conceito: B");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Conceito: C");
            }
            else
            {
                Console.WriteLine("Conceito: D");
            }
            if(faltas >= 10)
            {
                Console.WriteLine("Reprovado por faltas");
            }
        }
    }
}
