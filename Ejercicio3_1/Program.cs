using System; 

class Persona // Define la clase "Persona".
{
    // Atributos de la clase (propiedades privadas)
    private string nombre;
    private int edad;
    private string dni;

    // Constructor de la clase, para inicializar los atributos cuando se crea un objeto.
    public Persona(string nombre, int edad, string dni)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
    }

    // Método para obtener el valor del atributo "nombre"
    public string ObtenerNombre()
    {
        return this.nombre;
    }

    // Método para establecer el valor del atributo "nombre"
    public void EstablecerNombre(string nombre)
    {
        this.nombre = nombre;
    }

    // Método para obtener el valor del atributo "edad"
    public int ObtenerEdad()
    {
        return this.edad;
    }

    // Método para establecer el valor del atributo "edad"
    public void EstablecerEdad(int edad)
    {
        this.edad = edad;
    }

    // Método para obtener el valor del atributo "dni"
    public string ObtenerDNI()
    {
        return this.dni;
    }

    // Método para establecer el valor del atributo "dni"
    public void EstablecerDNI(string dni)
    {
        this.dni = dni;
    }

    // Método para mostrar los detalles de la persona
    public void MostrarDetalles()
    {
        Console.WriteLine($"Nombre: {this.nombre}, Edad: {this.edad}, DNI: {this.dni}");
    }
}

class Program // Clase principal que contiene el punto de entrada del programa
{
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Persona
        Persona persona1 = new Persona("Juan Pérez", 30, "12345678A");

        // Mostrar los detalles de la persona usando el método MostrarDetalles
        persona1.MostrarDetalles();

        // Cambiar algunos atributos de la persona utilizando los métodos Establecer
        persona1.EstablecerNombre("Carlos García");
        persona1.EstablecerEdad(35);

        // Mostrar los detalles actualizados
        Console.WriteLine("\nDetalles actualizados:");
        persona1.MostrarDetalles();
    }
}
