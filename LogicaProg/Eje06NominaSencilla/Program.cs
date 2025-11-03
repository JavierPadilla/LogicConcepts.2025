using shared;

namespace Eje06NominaSencilla
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var answer =string.Empty;
           var options = new List<string> {"s", "n" };

            do 
            {
                var name = Aga.PidaString(
                    "Nombre del empleado...........:");
                var nHoras = Aga.PidaDecimal(
                    "Numero de horas trabajadas....:");
                var valorHora = Aga.PidaDecimal(
                    "Cual es el valor de la hora?  $");
                var salarioMinimo = Aga.PidaDecimal(
                    "Cual es el salario minimo?    $");

                var salario = nHoras * valorHora;

                Console.WriteLine($"Nombre del empleado:   {name}");
                if (salario > salarioMinimo)
                {
                    Console.WriteLine($"El Salario es de : $ {salario:C2}"  );
                }
                else
                {
                    Console.WriteLine($"....Se pagara un Salario minimo  de : $ {salarioMinimo:C2}");
                }
                do
                {
                    answer = Aga.GetValidOptions("Deseas continuar [s]i   [n]o : ", options);
                } while (!options.Any(x => x.Equals(answer, StringComparison.InvariantCultureIgnoreCase)));
                
            }while (answer!.Equals("s",StringComparison.InvariantCultureIgnoreCase));
        }
    }
}