using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Operadores_Atribuicao_Incremento_Decremento
{
    internal class Exercicio01
    {
        public static void Executar()
        {
            double temperatura = 25.5;
            char escalar = 'C';

            double aumentar = temperatura + 3.2;
            double diminuir = aumentar - 1.0;

            Console.WriteLine($"Temperatura atual: {aumentar}");
            Console.WriteLine($"Temperatura ajustada: {diminuir}");
            Console.WriteLine("Escalar: " + escalar);
        }
    }
    internal class Exercicio02
    {
        public static void Executar()
        {
            int lugar = 1;
            String num1 = "5";
            int convertido = Int32.Parse(num1);
            Console.WriteLine("Após {0}° incremento: {1}", lugar, convertido);
            ++lugar;
            convertido++;
            Console.WriteLine("Após {0}° incremento: {1}", lugar, convertido);
            ++lugar;
            convertido++;
            Console.WriteLine("Após {0}° incremento: {1}", lugar, convertido);
            lugar = 1;
            --convertido;
            Console.WriteLine("Após {0}° decremento: {1}", lugar, convertido);
            ++lugar;
            --convertido;
            Console.WriteLine("Após {0}° decremento: {1}", lugar, convertido);
        }
    }
    internal class Exercicio03 //(revisão geral: namespaces/interpolação + operadores aritméticos + atribuição)
    {
        public static void Executar()
        {
            String nome = "Matheus";
            int pontos = 0;
            int partida = 1;
            Console.WriteLine($"Jogador: {nome}");
            pontos += 10;
            Console.WriteLine($"Pontos após {partida}ª soma: {pontos}");
            pontos += 15;
            ++partida;
            Console.WriteLine("Pontos após {0}ª soma: {1}", partida, pontos);
            int fixo = 15;
            double media = (pontos + fixo) / partida;
            Console.WriteLine("Média com o segundo valor: " + media);
        }
    }
}
