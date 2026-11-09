using System;

class Program
{
    static void Main()
    {
       Console.WriteLine("Abecedario en mayúsculas (Z a A):");
            for (int i = 90; i >= 65; i--)
            {
                char letra = (char)i;
                string salida = Convert.ToString(letra);
                Console.Write($"{salida} ");
            }
    }
}
