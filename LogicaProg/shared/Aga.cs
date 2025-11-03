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
        public static string PidaString(string mensaje)
        {
            
            Console.Write(mensaje);
            return Console.ReadLine()!;


        }
        public static float PidaFlotante(string mensaje)
        {
            bool er = false;
            string numeroString;
            do
            {
                Console.Write(mensaje);
                numeroString = Console.ReadLine()!;

                if (float.TryParse(numeroString, out float numeroFloat) == true)
                {
                    return numeroFloat;
                }
                else
                {
                    Console.WriteLine($"Numero  Flotante : {numeroString} no valido\n ");
                    er = true;
                }
            } while (er == true);
            return 0;
        }
        public static decimal PidaDecimal(string mensaje)
        {
            bool er = false;
            string numeroString;
            do
            {
                Console.Write(mensaje);
                numeroString = Console.ReadLine()!;

                if (decimal.TryParse(numeroString, out decimal numeroDecimal) == true)
                {
                    return numeroDecimal;
                }
                else
                {
                    Console.WriteLine($"Numero  Flotante : {numeroString} no valido\n ");
                    er = true;
                }
            } while (er == true);
            return 0;
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
