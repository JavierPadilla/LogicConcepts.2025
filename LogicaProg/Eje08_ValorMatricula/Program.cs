

using shared;
using System.Net.Http.Headers;

namespace Eje08_ValorMatricula
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var answer =string.Empty;
            var options= new List<string> {"s","n" };
            do
            {
                var credits = Aga.PidaEntero("Introduce el numero de creditos : ");
                var creditValue = Aga.PidaDecimal("Valor o costo del credito? : ");
                var stratum = Aga.PidaEntero("¿cuál es el Estrato del estudiante? :");

                var registrationValue=CalculateRegistrationValue(credits, creditValue,stratum);
                var subsidy = CalculateSubsidy(stratum);

                Console.WriteLine($"Costo de la matricula.............. : {registrationValue:C2}");
                Console.WriteLine($"Valor del subsidio................. : {subsidy:C2}\n");

                do
                {
                    answer = Aga.GetValidOptions("¿Deseas Continuar [S]i,   [N]o ?: ",options);
                }while (!options.Any(x => x.Equals(answer,StringComparison.CurrentCultureIgnoreCase)));

            } while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
        }

        private static object CalculateSubsidy(int stratum)
        {
            if (stratum == 1) return 200000;
            if (stratum == 2) return 100000;
            return 0;
        }

        private static object CalculateRegistrationValue(int credits, decimal creditValue, int stratum)
        {
            decimal value=0.0M;
            if (credits <= 20) value= creditValue*credits;
            if (credits >20) value= creditValue*20+((credits-20)*(creditValue*2));
            if (stratum == 1) return value * 0.2M;
            if (stratum == 2) return value * 0.5M;
            if (stratum == 3) return value * 0.7M;
            return value;

        }
    }
}
