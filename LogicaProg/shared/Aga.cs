using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared

{
    public class Aga
    {
        public static int PidaEntero(string mensaje)
        {
            bool er = false;
            int numeroEntero;
            string numeroString;
            do
            {
                Console.Write(mensaje);
                numeroString = Console.ReadLine()!;

                if (int.TryParse(numeroString, out numeroEntero) == true)
                {
                    return numeroEntero;
                }
                else
                {
                    Console.WriteLine($"Numero {numeroString} no valido\n ");
                    er = true;
                }
            } while (er == true);
            return numeroEntero;
        }
        public static string? GetValidOptions(string menssage, List<string> options)
        {
            Console.Write(menssage);
            var answer = Console.ReadLine();
            if (options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
            {
                return answer;

            }
            return null;
        }
    }
}
