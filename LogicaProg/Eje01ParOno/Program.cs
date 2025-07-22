namespace Eje01ParOno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un numero entero  : ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n%2==0)
            {
                Console.WriteLine("El numero {0} es Par", n);

            }
            else
            {
                Console.WriteLine("El numero {0 es impar }",n);
            }
        }
    }
}