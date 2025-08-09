using shared;
using System.Diagnostics;

namespace Eje01ParOno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = string.Empty;
            var options = new List<string> { "s", "n" };
            do
            {
                var numeroEntero = Aga.PidaEntero("Introduce un numero entero : ");
                if (numeroEntero % 2 == 0)
                {
                    Console.WriteLine("El numero {0} es Par", numeroEntero);

                }
                else
                {
                    Console.WriteLine("El numero {0} es impar ", numeroEntero);
                }
                do
                {
                    answer = Aga.GetValidOptions("Deseas Continuar [s]i  [n]o ? :", options);
                } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
            } while (answer!.Equals("s",StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine("Game Over");
        }
    }
}