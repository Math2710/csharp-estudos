namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo;
            double alturaRentagulo;
            double resultado;

            Console.Write("Digite a base: ");
            baseRetangulo = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            alturaRentagulo = double.Parse(Console.ReadLine());
            resultado = multiplicacaoBaseAltura(baseRetangulo, alturaRentagulo);
            Console.WriteLine("A área é: {0}", resultado.ToString());
        }

        static double multiplicacaoBaseAltura(double base1, double altura1)
        {
            double resultado = base1 * altura1;
                return resultado;
        }
    }
}
