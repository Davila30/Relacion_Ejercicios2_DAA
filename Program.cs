using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("El número mayor es: {0}", num1 > num2 ? num1 : (num2 > num1 ? num2 : "Ambos son iguales"));
    }
}
