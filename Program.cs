using System;

class Program
{
    static void Main()
    {
       System.Collections.Stack pila = new System.Collections.Stack();

        Console.WriteLine("Introduce 3 valores enteros para agregarlos a la pila:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            int val = Convert.ToInt32(Console.ReadLine());
            pila.Push(val);
        }

        Console.WriteLine("\nValores actuales en la pila:");
        foreach (var item in pila)
        {
            Console.WriteLine(item);
        }

        if (pila.Count >= 2)
        {
            Console.WriteLine($"\nSacando elemento (Pop): {pila.Pop()}");
            Console.WriteLine($"Sacando elemento (Pop): {pila.Pop()}");
        }

        Console.WriteLine("\nValores de la pila tras extraer los dos elementos:");
        foreach (var item in pila)
        {
            Console.WriteLine(item);
        }
    }
}
