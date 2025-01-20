using System;
class Program 
{
    static void Main(string[] args) // Método principal, donde comienza la ejecución del programa.
    {
        Console.WriteLine("Ingrese la calificación (0 a 100):"); // Solicita al usuario que ingrese una calificación.
        int calificacion; // Declara una variable para almacenar la calificación.

        // Intenta convertir la entrada del usuario a un número entero.
        if (int.TryParse(Console.ReadLine(), out calificacion))
        {
            // Verifica si la calificación está dentro del rango válido.
            if (calificacion >= 0 && calificacion <= 100)
            {
                // Comprueba si la calificación es mayor o igual a 60.
                if (calificacion >= 60)
                {
                    Console.WriteLine("Aprobado"); // Muestra el mensaje "Aprobado".
                }
                else
                {
                    Console.WriteLine("Reprobado"); // Muestra el mensaje "Reprobado".
                }
            }
            else
            {
                // Informa al usuario que la calificación no está dentro del rango permitido.
                Console.WriteLine("Calificación no válida. Debe estar entre 0 y 100.");
            }
        }
        else
        {
            // Informa al usuario que la entrada no es un número válido.
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        }
    }
}
