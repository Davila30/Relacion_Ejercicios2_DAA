using System;

class Program
{
    static void Main()
    {
       Console.Write("Introduce una cadena de texto: ");
            string texto = Console.ReadLine()!;

            Console.WriteLine($"Longitud: {texto.Length}");
            Console.WriteLine($"¿Contiene 'abc'?: {texto.Contains("abc")}");
            Console.WriteLine($"Reemplazar 'a' por '*': {texto.Replace('a', '*').Replace('A', '*')}");
            Console.WriteLine($"En mayúsculas: {texto.ToUpper()}");
            Console.WriteLine($"En minúsculas: {texto.ToLower()}");

            if (texto.Length > 0)
                Console.WriteLine($"Eliminar carácter en posición 0: {texto.Remove(0, 1)}");

            if (texto.Length >= 4)
                Console.WriteLine($"Subcadena (inicio 1, longitud 3): {texto.Substring(1, 3)}");
            else
                Console.WriteLine("Cadena demasiado corta para extraer la subcadena de prueba.");
    }
}
