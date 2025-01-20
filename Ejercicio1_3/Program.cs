using System;

namespace Ejerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Empieza del numero 1 al 50
            for (int i = 1; i <= 50; i++)
            {
                // Verifica si el numero es divisible por 3 y por 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz"); // si es divisible para 3 y 5 imprime FizzBuzz
                    
                }
                // si es solo divisible por 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz"); // imprime Fizz si es solo divisible por 3

                }
                // si es solo divisible por 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz"); // imprime Buzz si es solo divisible por 5
                }
                // si no es divisible ni por 3 ni 5 imprime el numero
                else
                {
                    Console.WriteLine(i); // imprime el numero actual
                }
            }

        }
    }
}
