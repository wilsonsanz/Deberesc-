using System; 

class Program 
{
    static void Main(string[] args) // Método principal, donde comienza la ejecución del programa.
    {
        // Solicita al usuario que ingrese el primer número.
        Console.WriteLine("Ingrese el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a un número decimal.

        // Solicita al usuario que ingrese el segundo número.
        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine()); // Convierte la entrada a un número decimal.

        // Solicita al usuario que ingrese el operador para la operación a realizar.
        Console.WriteLine("Ingrese el operador (+, -, *, /):");
        char operador = Convert.ToChar(Console.ReadLine()); // Convierte la entrada a un carácter.

        double resultado; // Declara una variable para almacenar el resultado.

        // Utiliza un "switch" para realizar la operación según el operador ingresado.
        switch (operador)
        {
            case '+': // Si el operador es suma
                resultado = numero1 + numero2;
                Console.WriteLine($"El resultado de {numero1} + {numero2} es: {resultado}");
                break;
            case '-': // Si el operador es resta
                resultado = numero1 - numero2;
                Console.WriteLine($"El resultado de {numero1} - {numero2} es: {resultado}");
                break;
            case '*': // Si el operador es multiplicación
                resultado = numero1 * numero2;
                Console.WriteLine($"El resultado de {numero1} * {numero2} es: {resultado}");
                break;
            case '/': // Si el operador es división
                if (numero2 != 0) // Verifica si el divisor no es cero
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"El resultado de {numero1} / {numero2} es: {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero."); // Informa si el divisor es cero.
                }
                break;
            default: // Si el operador no es válido
                Console.WriteLine("Operador no válido. Por favor, ingrese uno de los siguientes: +, -, *, /.");
                break;
        }
    }
}
