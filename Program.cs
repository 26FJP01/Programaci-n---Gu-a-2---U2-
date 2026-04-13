using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dias de la semana");
        int dia;
        dia=Convert.ToInt32(Console.ReadLine());
        switch(dia) {
             case 1:
                Console.WriteLine("Lunes");
                break;
             case 2:
                Console.WriteLine("martes");
                break;
             case 3 :
                Console.WriteLine("miercoles");
                break;
             case 4:
                Console.WriteLine("jueves");
                break;
             case 5:
                console.WriteLine("viernes");
                break;
             case 6:
                Console.WriteLine("sabado");
                break;
             case 7:
                Console.WriteLine("domingo");
                break;
                default:
                Console.WriteLine("diguite un numero del 1 al 7");

    }
}