namespace Eje02NumeroMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = string.Empty;
            int a, b, c;
            int mayor, medio, menor;

            do
            {
                Console.WriteLine("Introduce 3 numeros enteros \n");

                a = Aga.PidaEntero("Introduce el primer numero :");
                b = Aga.PidaEntero("Introduce el segundo numero :");
                c = Aga.PidaEntero("Introduce el tercer numero :");

                if (a != b && b != c) //--todos son diferentes
                {
                    if (a > b && a > c)
                    {
                        mayor = a;
                        if (b > c)
                        {
                            medio = b;
                            menor = c;
                        }
                        else
                        {
                            medio = c;
                            menor = b;
                        }
                    }
                    else
                    {
                        if (b > a && b > c)
                        {
                            mayor = b;
                            if (c > a)
                            {
                                medio = c;
                                menor = a;
                            }
                            else
                            {
                                medio = a; 
                                menor = c;
                            }
                        }
                        else
                        {
                            mayor = c;
                            if (a > b)
                            {
                                medio = a;
                                menor = b;

                            }
                            else
                            {
                                medio = b;
                                menor = a;
                            }


                        }
                    }
                }
                else// mas de algun numero es igual a otro
                {
                    Console.WriteLine("\nExisten uno o mas numeros iguales, intente de nuevo \n");
                    continue;
                }
                Console.WriteLine("\nEl numero mayor es {0} ", mayor);
                Console.WriteLine("El numero del medio es {0} ",medio);
                Console.WriteLine("El numero menor es {0} \n", menor);


                Console.WriteLine("Presiona 's' para salir  o cualquier otra tecla para continuar ");
                answer = Console.ReadLine();
            } while (answer!.ToLower() != "s");
        }
    }
}