using System; 
class Circulo // Define la clase "Circulo" que representa un círculo con un centro en (x, y) y un radio.
{
    // Atributos de la clase (propiedades privadas)
    private double x;
    private double y;
    private double radio;

    // Constructor de la clase, para inicializar los valores de x, y y radio cuando se cree un objeto de tipo Circulo.
    public Circulo(double x, double y, double radio)
    {
        this.x = x;
        this.y = y;
        this.radio = radio;
    }

    // Método para obtener el valor de x (coordenada x del centro del círculo)
    public double ObtenerX()
    {
        return this.x;
    }

    // Método para establecer el valor de x
    public void EstablecerX(double x)
    {
        this.x = x;
    }

    // Método para obtener el valor de y (coordenada y del centro del círculo)
    public double ObtenerY()
    {
        return this.y;
    }

    // Método para establecer el valor de y
    public void EstablecerY(double y)
    {
        this.y = y;
    }

    // Método para obtener el valor del radio del círculo
    public double ObtenerRadio()
    {
        return this.radio;
    }

    // Método para establecer el valor del radio del círculo
    public void EstablecerRadio(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio; // Fórmula del área: π * r^2
    }

    // Método para mostrar los detalles del círculo
    public void MostrarDetalles()
    {
        Console.WriteLine($"Círculo con centro en ({this.x}, {this.y}) y radio {this.radio}.");
    }
}

class Program // Clase principal que contiene el punto de entrada del programa
{
    static void Main(string[] args)
    {
        // Crear un objeto de tipo Circulo con centro en (2, 3) y radio 5
        Circulo circulo1 = new Circulo(2, 3, 5);

        // Mostrar los detalles del círculo
        circulo1.MostrarDetalles();

        // Calcular y mostrar el área del círculo
        double area = circulo1.CalcularArea();
        Console.WriteLine($"El área del círculo es: {area:F2} unidades cuadradas.");

        // Cambiar el radio del círculo utilizando el método EstablecerRadio
        circulo1.EstablecerRadio(10);

        // Mostrar los detalles y el área del círculo después de cambiar el radio
        Console.WriteLine("\nDetalles actualizados:");
        circulo1.MostrarDetalles();
        area = circulo1.CalcularArea();
        Console.WriteLine($"El área del círculo actualizado es: {area:F2} unidades cuadradas.");
    }
}
