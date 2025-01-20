using System; 
class Punto // Define la clase "Punto" que representa un punto en el plano cartesiano.
{
    // Atributos de la clase (propiedades privadas)
    private double x;
    private double y;

    // Constructor de la clase, para inicializar los valores de x y y cuando se cree un objeto de tipo Punto.
    public Punto(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Método para obtener el valor de x
    public double ObtenerX()
    {
        return this.x;
    }

    // Método para establecer el valor de x
    public void EstablecerX(double x)
    {
        this.x = x;
    }

    // Método para obtener el valor de y
    public double ObtenerY()
    {
        return this.y;
    }

    // Método para establecer el valor de y
    public void EstablecerY(double y)
    {
        this.y = y;
    }

    // Método para mostrar las coordenadas del punto
    public void MostrarCoordenadas()
    {
        Console.WriteLine($"El punto tiene las coordenadas: ({this.x}, {this.y})");
    }

    // Método para calcular la distancia entre este punto y otro punto dado
    public double CalcularDistancia(Punto otroPunto)
    {
        double dx = this.x - otroPunto.ObtenerX(); // Diferencia en x
        double dy = this.y - otroPunto.ObtenerY(); // Diferencia en y
        return Math.Sqrt(dx * dx + dy * dy); // Fórmula de la distancia euclidiana
    }
}

class Program // Clase principal que contiene el punto de entrada del programa
{
    static void Main(string[] args)
    {
        // Crear dos objetos de tipo Punto con diferentes coordenadas
        Punto punto1 = new Punto(3, 4);
        Punto punto2 = new Punto(7, 1);

        // Mostrar las coordenadas de ambos puntos
        punto1.MostrarCoordenadas();
        punto2.MostrarCoordenadas();

        // Calcular y mostrar la distancia entre los dos puntos
        double distancia = punto1.CalcularDistancia(punto2);
        Console.WriteLine($"La distancia entre los dos puntos es: {distancia:F2} unidades");
    }
}
