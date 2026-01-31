using shared;

namespace Eje10_AlmacenSuceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Almacenes SUCESO S.A. desea saber el valor de venta de un producto VR_V, a partir de la siguiente información que \r\n" +
                "posee de éste: \r\n\n" +
                "Costo de compra CC \r\n\n" +
                "Tipo de producto TP (Perecedero o No perecedero). \r\n" +
                "Tipo de conservación TC (frio o Ambiente)  \r\n" +
                "Periodo de Conservación en días. PC \r\n" +
                "Periodo de almacenamiento en días PA \r\n" +
                "Volumen en litros VOL \r\n" +
                "Medio de almacenamiento MA (Nevera, congelador, estantería y guacal) \r\n\n" +
                "El valor de venta VR_V es igual a:   \r\n\n" +
                "El 20% más del valor del producto VR_P, cuando el tipo de producto TP corresponde a un artículo no perecedero, o El \r\n" +
                "40% más del valor del producto VR_P, cuando el tipo de producto TP corresponde a un artículo perecedero. \r\n\n" +
                "El valor del producto VR_P, se calcula de la suma del Costo de compra CC, costo de almacenamiento CA y costo de \r\n" +
                "exhibición CE, multiplicados por el porcentaje de depreciación del producto PDP. \r\n\n" +
                "Los costos y el porcentaje de depreciación deben ser calculados en subprogramas así: \r\n\n" +
                "Función Costo de Almacenamiento.  En este se debe calcular el costo de almacenamiento CA para ser devuelto al \r\n" +
                "programa principal. \r\n\n" +
                "El costo de almacenamiento CA, se diferencia para artículos perecederos y no perecederos.  \r\n\n" +
                "• Para los productos perecederos: \r\n\n" +
                "Costo de almacenamiento CA es igual al 5% del costo de compra CC cuando se trata de un producto de tipo de \r\n" +
                "conservación TC en frio y con un período de conservación PC inferior a 10 días. \r\n" +
                "Costo de almacenamiento CA es igual al 10% del costo de compra CC cuando se trata de un producto de tipo de \r\n" +
                "conservación TC en frio y con un período de conservación PC superior o igual  10 días. \r\n" +
                "Costo de almacenamiento CA es igual al 3% del costo de compra CC cuando se trata de un producto de tipo de \r\n" +
                "conservación TC en ambiente y con un período de almacenamiento PA en inferior a 20 días. \r\n" +
                "Costo de almacenamiento CA es igual al 10% del costo de compra CC cuando se trata de un producto de tipo de \r\n" +
                "conservación TC en ambiente y con un período de almacenamiento PA superior  a 20 días. \r\n" +
                "Costo de almacenamiento CA es igual al 5% del costo de compra CC cuando se trata de un producto de tipo de \r\n" +
                "conservación TC en ambiente y con un período de almacenamiento PA  exacto a 20 días. \r\n" +
                "\r\n" +
                "• Para los productos no perecederos \r\n\n" +
                "El costo de almacenamiento CA se calcula a través de su volumen en litros VOL así: \r\n" +
                "Costo de almacenamiento CA es igual al 10% del costo de compra CC cuando el volumen VOL es mayor o igual a los \r\n" +
                "50 litros,  \r\n" +
                "Costo de almacenamiento CA es igual  al 20% del costo de compra CC cuando el volumen VOL es menor a los 50 \r\n" +
                "litros. \r\n" +
                "Función Porcentaje Depreciación del Producto.  En este se debe calcular el porcentaje de depreciación del producto \r\n" +
                "PDP, para ser devueltos al programa principal. \r\n" +
                "El porcentaje de depreciación del producto PDP es igual al 0.95 cuando el período de almacenamiento PA es inferior a \r\n" +
                "30 días, o \r\n" +
                "El porcentaje de depreciación del producto PDP es igual al 0.85 cuando el período de almacenamiento PA es superior o \r\n" +
                "igual a 30 días \r\n" +
                "Función Costo de  e: El costo de exhibición CE también se diferencia entre artículos perecederos y no perecederos, \r\n" +
                "calculándose así: \r\n" +
                "• Para los productos perecederos: \r\n" +
                "Aquellos artículos perecederos cuyo tipo de conservación TC es frio, y el medio de almacenamiento MA es nevera, el \r\n" +
                "costo de exhibición CE corresponde al doble del costo de almacenamiento CA. \r\n" +
                "Aquellos artículos perecederos cuyo tipo de conservación TC es frio, y el medio de almacenamiento MA es \r\n" +
                "congelador, el costo de exhibición CE corresponde al del costo de almacenamiento CA. \r\n\n" +
                "• Para los productos no perecederos: \r\n" +
                "El costo de exhibición CE corresponde al 5% del costo de almacenamiento CA, para los productos cuyo medio de \r\n" +
                "almacenamiento MA es en estantería \r\n" +
                "El costo de exhibición CE corresponde al 7% del costo de almacenamiento CA, para los productos cuyo medio de \r\n" +
                "almacenamiento MA es en guacal ");

            var answer = string.Empty;
            var options = new List<string> { "S", "N" };
            var tipoProducto =new List<string> {"P","N" };
            var tipoConservacion = new List<string> { "F", "A" };
            var tipoAlmacenamiento = new List<string> { "N", "C", "E", "G" };
            decimal ValorProducto, ValorVenta,CostoCompra,CostoAlmacenamiento,CostoExhibicion,PorcentajeDepresiacion;

            String Producto,Conservacion,Almacenamiento;
            do
            {
                #region EntradaDeDatos
                CostoCompra = Aga.PidaDecimal("\n¿Cual es el costo de Compra ?  :");
                do
                {
                    Producto = Aga.GetValidOptions("\n¿Tipo de producto? [P]erecedero  [N]}o perecedero  : ",tipoProducto)!;
                } while (!tipoProducto.Any(x => x.Equals(Producto, StringComparison.CurrentCultureIgnoreCase)));
                do
                {
                    Conservacion = Aga.GetValidOptions("\n¿Tipo de Conservacion? [F]rìo  [A]}mbiente   : ", tipoConservacion)!;
                } while (!tipoConservacion.Any(x => x.Equals(Conservacion, StringComparison.CurrentCultureIgnoreCase)));
                int diasConsercacion = Aga.PidaEntero("Dìas de consercaciòn en dìas?  :");
                int diasPeriodoAlamacenamiento = Aga.PidaEntero("\n ¿Periodo de Almacenamiento en dìas?  :");
                float Vol = Aga.PidaFlotante("\n¿Volumen en litros?  :");
                do
                {
                    Almacenamiento = Aga.GetValidOptions("\n¿Tipo de Alamacenamiento? [N]evera  [C]}ongelador  [E]stanterìa  [G]uacal  : ", tipoAlmacenamiento)!;
                } while (!tipoAlmacenamiento.Any(x => x.Equals(Almacenamiento, StringComparison.CurrentCultureIgnoreCase)));
                #endregion
               
                PorcentajeDepresiacion = CalcularPDP(diasPeriodoAlamacenamiento);
                CostoAlmacenamiento = CalcularCA(Producto,CostoCompra,Conservacion,diasConsercacion,diasPeriodoAlamacenamiento, Vol);
                CostoExhibicion = CalcularCE(Producto,Conservacion,Almacenamiento,CostoAlmacenamiento);
                ValorProducto = CalcularValorProducto(CostoCompra, CostoAlmacenamiento, CostoExhibicion, PorcentajeDepresiacion);
                ValorVenta = CalcularValorVenta(Producto, ValorProducto);

                do
                {
                    answer = Aga.GetValidOptions("\n ¿Desea Continuar con otro calculo nuevo :  [S]í     [N]o  :", options)!;
                } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

            } while (answer!.Equals("S",StringComparison.CurrentCultureIgnoreCase));

        }

        private static decimal CalcularCE(string producto, string conservacion, string almacenamiento, decimal costoAlmacenamiento)
        {
            if (producto== "P")
            {
                if(conservacion=="F" && almacenamiento == "N") return costoAlmacenamiento * 2;
                if (conservacion == "F" && almacenamiento == "C") return costoAlmacenamiento;
            }
            else
            {
                if (almacenamiento == "E") return costoAlmacenamiento * 0.05M;
                if (almacenamiento == "G") return costoAlmacenamiento * 0.07M;
            }
            return 0;
        }

        private static decimal CalcularPDP(int diasPeriodoAlamacenamiento)
        {
            if (diasPeriodoAlamacenamiento < 30) return 0.95M;
            return 0.85M;
        }

        private static decimal CalcularCA(string producto, decimal costoCompra, string conservacion, int diasConsercacion, int diasPeriodoAlamacenamiento,float Vol)
        {
            throw new NotImplementedException();
        }

        private static decimal CalcularValorProducto(decimal costoCompra, decimal costoAlmacenamiento, decimal costoExhibicion, decimal porcentajeDepresiacion)
        {
            throw new NotImplementedException();
        }

        private static decimal CalcularValorVenta(string producto, decimal valorProducto)
        {
            throw new NotImplementedException();
        }
    }
}
