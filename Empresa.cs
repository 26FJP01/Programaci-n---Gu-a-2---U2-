internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***********************");
        Console.WriteLine("EMPRESA T&S, S.A de C.A");
        Console.WriteLine("====FORMAS DE PAGO====");
        Console.WriteLine("1- EFECTIVO");
        Console.WriteLine("2- TARJETA DE CRÉDITO");
        Console.WriteLine("3- VALE DE REGALO");
        Console.WriteLine("***********************");
        int cant, opc;
        double precioB = 650;
        double iva = 0.12;
        double precioIva, totSinDesc, desc = 0, totPagar;
        string formaPago = "";
        Console.Write("Ingrese la cantidad de impresores deseados: ");
        cant = int.Parse(Console.ReadLine());
        Console.Write("Seleccione la forma de pago (indique el numero): ");
        opc = int.Parse(Console.ReadLine());
        precioIva = precioB+ (precioB * iva);
        totSinDesc = precioIva * cant;

        switch (opc)
        {
            case 1:
                desc = totSinDesc * 0.10;
                formaPago = "EFECTIVO";
                break;

            case 2:
                desc = totSinDesc * 0.05;
                formaPago = "TARJETA DE CRÉDITO";
                break;

            case 3:
                desc = totSinDesc * 0.15;
                formaPago = "VALE DE REGALO";
                break;

            default:
                Console.WriteLine("OPCIÓN INVALIDA");
                break;
        }
        totPagar = totSinDesc - desc;
        // Resultados
        Console.WriteLine("\n*** DETALLE DE COMPRA ***");
        Console.WriteLine("Cantidad de impresoras a comprar: " + cant);
        Console.WriteLine("Precio unitario con IVA: Q. " + precioIva);
        Console.WriteLine("Total sin descuento: Q. " + totSinDesc);
        Console.WriteLine("Forma de pago: " + formaPago);
        Console.WriteLine("Descuento realizado: Q. " + desc);
        Console.WriteLine("Total a pagar: Q. " + totPagar);
    }
}