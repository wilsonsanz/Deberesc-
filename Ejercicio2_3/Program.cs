using System; 

class Program 
{
    static void Main(string[] args) // Método principal, donde comienza la ejecución del programa.
    {
        Console.WriteLine("Ingrese un número:"); // Solicita al usuario que ingrese un número.
        int numero; // Declara una variable para almacenar el número ingresado.

        // Intenta convertir la entrada del usuario a un número entero.
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            // Verifica en qué rango se encuentra el número.
            if (numero < 10)
            {
                Console.WriteLine("Menor que 10"); // Informa que el número es menor que 10.
            }
            else if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("Entre 10 y 20"); // Informa que el número está entre 10 y 20.
            }
            else
            {
                Console.WriteLine("Mayor que 20"); // Informa que el número es mayor que 20.
            }
        }
        else
        {
            // Informa al usuario que la entrada no es válida si no es un número entero.
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        }
    }
}
