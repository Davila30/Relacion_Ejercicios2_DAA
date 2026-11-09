using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce los Kilowatios consumidos: ");
            double kw = double.Parse(Console.ReadLine()!);
            double precioKw;
            if (kw > 1800)
                precioKw = 0.8;
            else if (kw >= 1000)
                precioKw = 0.12;
            else
                precioKw = 0.14;
            double total = kw * precioKw;
            Console.WriteLine($"Total a pagar: {total:F2}€ (precio aplicado: {precioKw}€/kW)");
    }
}
