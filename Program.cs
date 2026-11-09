using System;

class Program
{
    static void Main()
    {
       Console.Write("Indica el tamaño del array: ");
        int tam = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[tam];

        for (int i = 0; i < tam; i++)
        {
            Console.Write($"Introduce el valor para la posición [{i}]: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nResultados:");
        foreach (int num in arr)
        {
            string tipo = (num % 2 == 0) ? "PAR" : "IMPAR";
            Console.WriteLine($"El número {num} es {tipo}");
        }
    }
}
