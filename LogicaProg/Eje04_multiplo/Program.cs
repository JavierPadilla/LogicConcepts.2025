




using shared;

Console.WriteLine("Programa que pide por consola dos numeros y determina \n si el segundo numero" +
                  "es o no multiplo del primer numero. :D");

int a = Aga.PidaEntero("Introduce el primer numero : ");
int b = Aga.PidaEntero("Introduce el segundo numero : ");

if (b % a == 0)
{
    Console.WriteLine("\nEl numero {0} es multiplo de {1} ", b, a);
}
else
{
    Console.WriteLine("\nEl numero {0}  no es multiplo de {1} ", b, a);
}