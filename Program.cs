using System;

class Program
{
    static void Main()
    {
       Console.Write("Introduce tu estado civil (C, S, V, D): ");
            char estado = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (estado)
            {
                case 'C':
                    Console.WriteLine("Tu estado civil es Casad@");
                    break;
                case 'S':
                    Console.WriteLine("Tu estado civil es Solter@");
                    break;
                case 'V':
                    Console.WriteLine("Tu estado civil es Viud@");
                    break;
                case 'D':
                    Console.WriteLine("Tu estado civil es Divorciad@");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
    }
}
