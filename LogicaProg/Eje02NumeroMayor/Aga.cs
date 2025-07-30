using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje02NumeroMayor
{
    public class Aga
    {
        public static int PidaEntero(string mensaje)
        {
            bool er= false;
            int numeroEntero;
            string numeroString;
            do
            {
                Console.Write(mensaje);
                numeroString = Console.ReadLine()!;
                
                if (int.TryParse(numeroString,out numeroEntero)==true)
                {
                    return numeroEntero;  
                }
                else
                {
                Console.WriteLine($"Numero {numeroString} no valido\n ");
                er = true;
                }
             }while (er==true);
            return numeroEntero;
        }
    }
}
