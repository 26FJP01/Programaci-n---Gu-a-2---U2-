internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("MESES DEL AÑO");
        int mes;
        Console.Write("Dime un número del 1 al 12: ");
        mes = Convert.ToInt32(Console.ReadLine());
        switch (mes)
        {
            case 1:
                Console.WriteLine("ENERO:31 días");
                break;
            case 2:
                Console.WriteLine("FEBRERO:28 (Si es año bisiesto 29) días");
                break;
            case 3:
                Console.WriteLine("MARZO:31 días");
                break;
            case 4:
                Console.WriteLine("ABRIL:30 días");
                break;
            case 5:
                Console.WriteLine("MAYO:31 días");
                break;
            case 6:
                Console.WriteLine("JUNIO:30 días");
                break;
            case 7:
                Console.WriteLine("JULIO:31 días");
                break;
            case 8:
                Console.WriteLine("AGOSTO:31 días");
                break;
            case 9:
                Console.WriteLine("SEPTIEMBRE:30 días");
                break;
            case 10:
                Console.WriteLine("OCTUBRE:31 días");
                break;
            case 11:
                Console.WriteLine("NOVIEMBRE:30 días");
                break;
            case 12:
                Console.WriteLine("DICIEMBRE:31 días");
                break;
            default:
                Console.WriteLine("DIGITE UN NUMERO ENTRE 1 Y EL 12");
                break;
        }
    }
}