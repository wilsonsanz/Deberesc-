using System;

class Program // Define la clase principal
{

    static void Main(string[] args) // Metodo principal, donde comienza la ejecucion del programa
    {
        // recorre los numeros del 0 al 100.
        for (int i = 0; i <= 100; i++)
        {
            // verificar si el numero es par
            if (i % 2 == 0)
            {
                // si es par imprimirlo en pantalla
                Console.WriteLine(i);
            }
        }
    }
}