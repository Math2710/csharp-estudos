using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _09_Estrutura_Repeticao_For
{
    internal class Exercicio1
    {
        public static void Executar()
        {
            int contadorMultiplos = 0;

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    contadorMultiplos++;

                }
            }
            Console.WriteLine($"Quantidade de múltiplos de 3 entre 1 e 20: {contadorMultiplos}");
        }
    }
    internal class Exercicio2
    {
        public static void Executar()
        {
            Console.Write("Digite o valor inicial do investimento: ");
            double valor_inicial = double.Parse( Console.ReadLine() );

            Console.Write("Digite a taxa mensal (ex: 0.02 para 2%): ");
            double taxa_mensal = double.Parse( Console.ReadLine() );

            for (int i = 1;i <= 6 ; i++)
            {
                valor_inicial += valor_inicial * taxa_mensal;
                Console.WriteLine($"Mês {i}: R$ {valor_inicial:F2} ");
            }
        }
    }
    internal class Exercicio3
    {
        public static void Executar()
        {
            for (int aluno = 1; aluno <= 3; aluno++)
            {
                Console.Write("Digite o nome do aluno " + aluno + ": ");
                string nome = Console.ReadLine();
                Console.Write($"Digite a nota do aluno {aluno}: ");
                float nota = float.Parse( Console.ReadLine() );
                string Nota;
                if (nota >= 9)
                {
                    Nota = "A";
                }
                else if (nota >= 7)
                {
                    Nota = "B";
                }
                else if (nota >= 5)
                {
                    Nota = "C";
                }
                else
                {
                    Nota = "D";
                }
                Console.WriteLine($"{nome}: {Nota}");
            }
        }
    }
}
