
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("MENU DE OPCIONES");
        int num1, ops, num2,;
        Console.WriteLine("la suma es");
        Console.WriteLine("2-resta");
        Console.WriteLine("3-multiplicacion");
        Console.WriteLine("4-división");
        ops = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ingrese la opcion");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
        switch(ops)
               case 1:
            Console.WriteLine("la suma es:", (num1 + num2);
            break;
        case 2:
            Console.WriteLine("la resta es:", (num1 - num2);
            break;
        case 3:
            Console.WriteLine("la multiplicacion es:", (num1 * num2);
            break;
        case 4:
            Console.WriteLine("la división es:", (num1 / num2);
            break;
        default
            Console.WriteLine("error al operar los numeros!!!");
        }
        } 
}