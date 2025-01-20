using System; 
class Program 
{
    static void Main(string[] args) // Método principal, donde comienza la ejecución del programa.
    {
        Console.WriteLine("Ingrese un número del 1 al 7:"); // Solicita al usuario que ingrese un número del 1 al 7.
        int numero; // Declara una variable para almacenar el número ingresado.

        // Intenta convertir la entrada del usuario a un número entero.
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            // Utiliza un "switch" para determinar el día de la semana según el número ingresado.
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes"); // Si el número es 1, muestra "Lunes".
                    break;
                case 2:
                    Console.WriteLine("Martes"); // Si el número es 2, muestra "Martes".
                    break;
                case 3:
                    Console.WriteLine("Miércoles"); // Si el número es 3, muestra "Miércoles".
                    break;
                case 4:
                    Console.WriteLine("Jueves"); // Si el número es 4, muestra "Jueves".
                    break;
                case 5:
                    Console.WriteLine("Viernes"); // Si el número es 5, muestra "Viernes".
                    break;
                case 6:
                    Console.WriteLine("Sábado"); // Si el número es 6, muestra "Sábado".
                    break;
                case 7:
                    Console.WriteLine("Domingo"); // Si el número es 7, muestra "Domingo".
                    break;
                default:
                    Console.WriteLine("Número no válido. Debe estar entre 1 y 7."); // Informa si el número no está entre 1 y 7.
                    break;
            }
        }
        else
        {
            // Informa al usuario si la entrada no es un número válido.
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        }
    }
}
