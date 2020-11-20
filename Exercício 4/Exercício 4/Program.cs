using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Triangulo();
            double k;

            do
            {
                Console.Write("Informe o valor da base do triângulo: ");
                k = double.Parse(Console.ReadLine());
                if (k > 0)
                {
                    a1.SetBase(k);
                }
            }
            while (k <= 0);

            Console.Write("Informe o valor da altura do triângulo: ");
            a1.SetAltura(double.Parse(Console.ReadLine()));

            Console.WriteLine($"O valor da área do triângulo é igual a {a1.CalcularArea()}");
        }
    }
}
