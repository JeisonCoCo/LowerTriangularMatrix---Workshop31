
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Ingrese orden de la matriz: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = i + j;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matriz[i, j],4}");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i >= j)
                    Console.Write($"{matriz[i, j],4}");
                else
                    Console.Write("    "); // Espacio vacío para mantener la forma
            }
            Console.WriteLine();
        }
    }
}
