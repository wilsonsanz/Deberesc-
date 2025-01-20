using System; 

class Program 
{
    static void Main(string[] args) // Método principal, donde comienza la ejecución del programa.
    {
        int suma = 0; // Variable para almacenar la suma, inicializada en 0.
        int i = 1;    // Variable para contar, inicializada en 1.

        // Bucle "while" que se ejecuta mientras "i" sea menor o igual a 100.
        while (i <= 100)
        {
            suma += i; // Suma el valor de "i" a la variable "suma".
            i++;       // Incrementa el valor de "i" en 1.
        }

        // Imprime el resultado de la suma en la consola.
        Console.WriteLine("La suma de los primeros 100 números enteros es: " + suma);
    }
}
