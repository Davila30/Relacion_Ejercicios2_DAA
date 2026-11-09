using System;

class Program
{
    static void Main()
    {
       int[] datos = { 45, 12, 89, 3, 27, 64, 18, 90, 5, 33 };

            Console.WriteLine("Array desordenado original:");
            for (int i = 0; i < datos.Length; i++)
            {
                Console.Write($"{datos[i]} ");
            }
            Console.WriteLine();

            Array.Sort(datos);

            Console.WriteLine("\nArray ordenado con Array.Sort():");
            for (int i = 0; i < datos.Length; i++)
            {
                Console.Write($"{datos[i]} ");
            }
    }
}
