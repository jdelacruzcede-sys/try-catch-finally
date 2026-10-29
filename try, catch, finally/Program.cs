
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var notas = new List<int> { 90, 75, 88 };

        try
        {
            Console.WriteLine(notas[5]);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Fin de la lectura");
        }
    }
}

