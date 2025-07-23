namespace Eje01ParOno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroString=string.Empty;
            do
            {
                Console.Write("Introduce un numero entero  o presione 's' para Salir : ");
                numeroString = Console.ReadLine();
                if (numeroString.ToLower() = "s")
                {
                    continue;
                }
                
                int numeroEntero = 0;
                if (int.TryParse(numeroString,out numeroEntero))
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("El numero {0} es Par", numeroEntero);

                    }
                    else
                    {
                        Console.WriteLine("El numero {0 es impar }", numeroEntero);
                    }
                }
                else
                {
                    Console.WriteLine("Lo que ingresaste {0} no es un numero entero ",numeroString);
                }


            } while(numeroString.ToLower()!="s")
            
        }
    }
}