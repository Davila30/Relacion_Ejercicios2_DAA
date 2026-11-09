using System;

class Program
{
    static void Main()
    {
       Console.Write("Introduce un número entero no negativo: ");
            int n = int.Parse(Console.ReadLine()!);

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"El factorial de {n} es: {factorial}");
    }
}
