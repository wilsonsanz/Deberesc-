using System; 
class Program // Define la clase principal "Program".
{
    static void Main(string[] args) // Método principal, donde comienza la ejecución del programa.
    {
        int i = 1; // Inicializa la variable "i" con el valor 1.

        // Bucle "while" que se ejecuta mientras "i" sea menor o igual a 10.
        while (i <= 10)
        {
            Console.WriteLine(i); // Imprime el valor actual de "i" en la consola.
            i++; // Incrementa el valor de "i" en 1.
        }
    }
}
