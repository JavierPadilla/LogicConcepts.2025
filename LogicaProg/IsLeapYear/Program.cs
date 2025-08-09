using shared;

namespace isLeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------\t Ejercicio numero 5 \n" +
                "--------\t Programa que pide el anio como un numero entero \n" +
                "--------\t y deptermina se es o no un anio bisciesto \n");
            int year = Aga.PidaEntero("Introduce el year : ");
            var currentyear = DateTime.Now.Year;
            var me = string.Empty;

            if (year > currentyear)
            {
                me = "SERA";
            }
            else
            {
                if (year < currentyear)
                {
                    me = "FUE";
                }
                else
                {
                    me = "ES";
                }
            }

            if (year%400==0 || year%4==0 && year%100 !=0)
            {
                Console.WriteLine($"\nEL anio {year} {me} bisciesto");

            }
            else
            {
                Console.WriteLine($"\nEl anio no {year} {me} anio bisiesto");
            }
                
        }
    }
}