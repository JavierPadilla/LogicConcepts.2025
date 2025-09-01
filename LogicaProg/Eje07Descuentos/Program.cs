using System.Diagnostics;
using shared;

namespace Eje07Descuentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para un almacen \n" +
    "Calcula el total a pagar en base al numero de escritorios que el cliente lleva en su compra\n" +
    "Cada escritorio tiene un valor de $6500.0" +
    "\n" +
    "se otorga un 10% en la compra de menos de 5 unidades" +
    "se otorga un 20% en la compra de 5 a 9 unidades" +
    "se otorga un 40% en la compra de 10 o mas unidesdes\n");

            var answer = string.Empty;
            var options = new List<string> { "s", "n" };

            do
            {

                int esc = Aga.PidaEntero("Numero de Escritorios: ");
                double desc = 0.0;
                if (esc < 5) desc = (esc * 6500) * 0.1;
                if (esc < 10 && esc > 4) desc = (esc * 6500) * 0.2;
                if (esc > 9) desc = (esc * 6500) * 0.4;
                Console.WriteLine($"El valor a pagar es de : $ {(esc * 6500) - desc:C3}");

                do
                {
                    answer = Aga.GetValidOptions("Deseas continuar [s]i   [n]o : ", options);
                } while (!options.Any(x => x.Equals(answer, StringComparison.InvariantCultureIgnoreCase)));

            } while (answer!.Equals("s", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}