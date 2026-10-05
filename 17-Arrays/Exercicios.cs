using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _17_Arrays
{
    internal class Exercicio1
    {
        public static void Executar()
        {
            while (true)
            {
                int[] notas = new int[5] { 7, 8, 5, 9, 6 };
                Console.Write("Digite a posição (0 a 4): ");
                int posicao = int.Parse(Console.ReadLine());
                if (posicao < 0 || posicao > 4)
                {
                    Console.WriteLine("Digite uma posição válida!\n\r");
                }
               
                else
                {
                    Console.Write("Digite o novo valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    notas[posicao] = valor;
                    Console.WriteLine($"O novo elemento da posição {posicao} é {valor}\n\r");
                    break;
                }
            }
        }
    }
    internal class Exercicio2
    {
        public static void Executar()
        {
            double[] valores = new double[6] { 5.50, 4.80, 19.99, 55.00, 110.00, 15.00};
            double total = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("Posição {0}: R$ {1}", i, valores[i]);
                total += valores[i];
            }
            Console.WriteLine($"ToTal: R$ {total}");
        }
    }
    internal class Exercicio3
    {
        public static void Executar()
        {
            int[] idade = { 1, 5, 18, 15, 20 };
            foreach(int classificacao in idade)
            {
                if(classificacao >= 18)
                {
                    Console.WriteLine($"{classificacao}: Maior de idade");
                }
                else
                {
                    Console.WriteLine($"{classificacao}: Menor de idade");
                }
            }
        }
    }
}

