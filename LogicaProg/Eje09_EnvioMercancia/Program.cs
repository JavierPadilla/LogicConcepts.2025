using shared;

namespace Eje09_EnvioMercancia
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region instrucciones
            Console.WriteLine("\t\t Envío de Mercancías\n" +
                "Una Empresa de envío de mercancía, tiene un plan de tarifas y descuentos sobre el valor \n" +
                "del envío de mercancía de sus clientes:\n\n" +
                "Tarifas:\n" +
                "- Si el peso de la mercancía es inferior a 100 kg, la tarifa para el envío de esta es de 20,000 pesos.\n" +
                "- Si el peso de la mercancía esta entre 100 y 150 kg, la tarifa para el envio de esta es de 25,000 pesos.\n" +
                "- Si el peso de la mercancía es superior a 150 kg y menor o igual a 200kg, la tarifa es de 30,000 pesos.\n" +
                "- Si el peso de la mercancía es superior a 200kg, la tarifa es de 35,000 y además por cada 10 kg adicionales\n" +
                "  se paga 2,000 pesos más.\n\n" +
                "Descuentos:\n" +
                "- Si el valor de la mercancía esta entre 300,0000 y 600,000 pesos se hace un descuento del 10% sobre el valor del envío\n" +
                "- Si el valor de la mercancía es superior a 600,000 pero menor o igual a 1,000,000 de pesos el descuento es del 20%.\n" +
                "- Si el valor de la mercancía es superior a 1,000,000 pesos se hace un descuento del 30%.\n\n" +
                "Promociones:\n" +
                "- Si es día de promoción [Lunes] y paga con tarjeta propia del almacén, solo paga el 50% del costo del envío.\n" +
                "- Si paga en efectivo y el valor de la mercancía es superior a 1,000,000, solo paga el 60%.\n" +
                "Si el cliente aplica a una promoción, no puede aplicar a un descuento. Se debe obtener el valor total del envío.\n");
            #endregion

            
            var answer = string.Empty;
            var options = new List<string> { "s", "n" };
            var Fpago=new List<string> {"e","t" };
            do
            {
                var Peso = Aga.PidaFlotante("Peso de la mercancía  : ");
                var Value = Aga.PidaDecimal("Valor de la mercancía :");
                string ismondey;
                string pago;
                do
                {
                    ismondey = Aga.GetValidOptions("Es lunes [S]í [N]o :", options)!;
             
                } while (!options.Any(x => x.Equals(ismondey, StringComparison.CurrentCultureIgnoreCase)));
                do
                {
                   pago=Aga.GetValidOptions("Tipo de pago [E]fectivo  [T]arjeta : ",Fpago)!;
                 } while (!Fpago.Any(x =>x.Equals(pago,StringComparison.CurrentCultureIgnoreCase)));

                decimal Tarifa = CalcularTarifa(Peso, Value, ismondey, pago);
                Console.WriteLine($"\nLa tarifa a pagar es de : $ {Tarifa:N2}");

                do
                {
                    answer = Aga.GetValidOptions(" ¿Desea Continuar con otro calculo nuevo :  [S]í     [N]o  :", options)!;
                } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

            } while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

           
        }

        private static decimal CalcularTarifa(float peso, decimal value, string ismondey, string pago)
        {
            decimal x = 0.0M;
            peso = (int)peso;
            if (peso < 100) x = 20000M;
            if (peso >= 100 && peso <= 150) x = 25000M;
            if (peso > 150 && peso <= 200) x = 30000M;
            int y = (int)peso - 200;
            x = 35000M+ (int)(y/10)*2000M;
            //Promociones
            if (ismondey.ToLower() == "s" && pago.ToLower()=="t") return x * 0.5M;
            if (pago.ToLower() == "e" && value > 1000000M) return x * 0.6M;
            // Descuentos
            if (value >= 300000M && value <= 600000M) return x * 0.9M;
            if (value > 600000M && value <= 1000000M) return x * 0.8M;
            if (value > 1000000M) return x * 0.7M;

            return x;

        }
    }
}
