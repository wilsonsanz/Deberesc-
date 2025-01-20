using System; // Importa el espacio de nombres "System", que contiene funcionalidades básicas como entrada/salida.

class Program // Define una clase llamada "Program", que es el punto de entrada del programa.
{
    static void Main(string[] args) // Método principal, donde comienza la ejecución del programa.
    {
        // Inicia un bucle "for" que recorre desde 0 hasta 100, incrementando de 2 en 2.
        for (int i = 0; i <= 100; i += 2)
        {
            // Imprime el valor actual de la variable "i" en la consola.
            Console.WriteLine(i);
        }
    }
}
