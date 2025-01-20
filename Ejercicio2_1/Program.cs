
class Program 
{
    static void Main(string[] args) // Método principal, donde comienza la ejecución del programa.
    {
        Console.WriteLine("Ingrese un número:"); // Solicita al usuario que ingrese un número.
        double numero; // Declara una variable para almacenar el número ingresado.
        
        // Intenta convertir la entrada del usuario a un número.
        if (double.TryParse(Console.ReadLine(), out numero))
        {
            // Verifica si el número es mayor que 0.
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo."); // Informa que el número es positivo.
            }
            // Verifica si el número es menor que 0.
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo."); // Informa que el número es negativo.
            }
            // Si ninguna de las condiciones anteriores se cumple, el número es 0.
            else
            {
                Console.WriteLine("El número es cero."); // Informa que el número es cero.
            }
        }
        else
        {
            // Si la entrada no es un número válido, informa al usuario.
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        }
    }
}
