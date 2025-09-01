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

            var answer = string.Empty;
            var options = new List<string> { "s", "n" };

            do
            {
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

                if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
                {
                    Console.WriteLine($"\nEL anio {year} {me} bisciesto");

                }
                else
                {
                    Console.WriteLine($"\nEl anio no {year} {me} anio bisiesto");
                }


                do
                {
                    answer = Aga.GetValidOptions("Deseas continuar [s]i   [n]o : ", options);
                } while (!options.Any(x => x.Equals(answer, StringComparison.InvariantCultureIgnoreCase)));

            } while (answer!.Equals("s", StringComparison.InvariantCultureIgnoreCase)); 
                
        }
    }
}