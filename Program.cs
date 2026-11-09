using System;

class Program
{
    static void Main()
    {
       Console.Write("Introduce un número del 1 al 9: ");
            int num = int.Parse(Console.ReadLine()!);

            if (num < 1 || num > 9)
            {
                Console.WriteLine("Error: el número introducido está fuera del rango permitido (1 al 9).");
                return;
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
    }
}
