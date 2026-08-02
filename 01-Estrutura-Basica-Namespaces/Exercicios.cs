using System;
using System.Collections.Generic;
using System.Text;

namespace Estudos
{
    internal class Exercicio01
    { 
        public static void Executar()
        {
            Console.WriteLine("Matheus Westphal dos Santos");
        }
    }
    internal class  Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Apredendo C#");
            Console.WriteLine("Curso Bóson Treinamentos");
            Console.WriteLine("Aula 02 - Namespaces e using");
        }
    }
    internal class Exercicio03 
    {
        public static void Executar()
        {
            Console.Write("Olá, ");
            Console.Write("Matheus");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Fim do programa");
        }
    }
    internal class Exercicio04
    {
        public static void Executar()
        {
            String nome = "Matheus";
            Console.WriteLine($"Olá {nome}!");
            Console.WriteLine($"Bem-vindo ao curso de C#, {nome}");
            Console.WriteLine($"O nome {nome} tem {nome.Length} caracteres.");
        }
    }
}