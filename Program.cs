using System;

class Program
{
    static void Main()
    {
       Random rnd = new Random();
            int aleatorio = rnd.Next(10, 31);
            Console.WriteLine($"Número aleatorio generado (10-30): {aleatorio}");
    }
}
