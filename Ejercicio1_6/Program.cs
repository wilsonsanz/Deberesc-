using System; 

class Program 
{
    static void Main(string[] args) // Método principal, donde comienza la ejecución del programa.
    {
        int i = 0; // Inicializa la variable "i" en 0, el primer número par.

        // Bucle "while" que se ejecuta mientras "i" sea menor o igual a 100.
        while (i <= 100)
        {
            Console.WriteLine(i); // Imprime el número actual (par) en la consola.
            i += 2; // Incrementa "i" en 2 para obtener el siguiente número par.
        }
    }
}
