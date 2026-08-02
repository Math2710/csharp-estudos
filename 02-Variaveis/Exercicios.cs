using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace _02_Variaveis
{
    internal class Exercicio
    {
       public static void Executar()
        {
            string nome = "Matheus";
            int idade = 21;
            bool estudante = true;
            float altura = 1.75f;

            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade.ToString());
            Console.WriteLine("altura: " + altura.ToString());
            Console.WriteLine("Estudante: " + estudante.ToString());
        }
    }
    internal class Exercicio2
    {
        public static void Executar()
        {
            float salario = 1500.5f;
            char Categoria = 'A';
            float salarioReajustado = 1800.75f;
            salario = salarioReajustado;
            float bonus = 200.25f;
            float salarioComBonus = salarioReajustado + bonus;


            Console.WriteLine("Salário: " + salario.ToString());
            Console.WriteLine("Categorio: " + Categoria.ToString());
            Console.WriteLine("Salário reajustado: " + salarioReajustado.ToString());
            Console.WriteLine("Salário com bônus: " + salarioComBonus.ToString());
        }
    }
    internal class Exercicio3
    {
        public static void Executar()
        {
            String produto = "Teclado";
            double preço = 89.9;
            int estoque = 15;
            Char categoria = 'T';
            bool promocao = true;

            Console.WriteLine($"Produto: {produto}");
            Console.WriteLine("Preço: " + preço.ToString());
            Console.WriteLine($"Quantidade em estoque: {estoque}");
            Console.WriteLine("Categoria (letra): " + categoria);
            Console.WriteLine($"Em promoção: {promocao}");
        }
    }
}
