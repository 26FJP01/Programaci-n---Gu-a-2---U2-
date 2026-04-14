internal class Program
{
    private static void Main(string[] args)
    {
        char caracte;
        Console.Write("Ingresa un Carácter (Vocal o Digito): ");
        caracte = Convert.ToChar(Console.ReadLine());
        switch (caracte)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
                Console.WriteLine("ES UNA VOCAL");
                break;
            default:
                if (caracte >= '1' && caracte <= '9')
                    Console.WriteLine("ES UN DIGITO");
                else
                    Console.WriteLine("NO ES DIGITO NI VOCAL");
                break;
        }
    }
}