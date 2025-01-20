using System; 

class Persona // Define la clase "Persona" que representa a una persona con sus atributos.
{
    // Atributos de la clase (propiedades privadas)
    private string nombre;
    private string apellido;
    private int edad;
    private string genero;

    // Constructor de la clase, para inicializar los valores de los atributos al crear un objeto de tipo Persona.
    public Persona(string nombre, string apellido, int edad, string genero)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.genero = genero;
    }

    // Método para obtener el valor del nombre
    public string ObtenerNombre()
    {
        return this.nombre;
    }

    // Método para establecer el valor del nombre
    public void EstablecerNombre(string nombre)
    {
        this.nombre = nombre;
    }

    // Método para obtener el valor del apellido
    public string ObtenerApellido()
    {
        return this.apellido;
    }

    // Método para establecer el valor del apellido
    public void EstablecerApellido(string apellido)
    {
        this.apellido = apellido;
    }

    // Método para obtener el valor de la edad
    public int ObtenerEdad()
    {
        return this.edad;
    }

    // Método para establecer el valor de la edad
    public void EstablecerEdad(int edad)
    {
        this.edad = edad;
    }

    // Método para obtener el valor del género
    public string ObtenerGenero()
    {
        return this.genero;
    }

    // Método para establecer el valor del género
    public void EstablecerGenero(string genero)
    {
        this.genero = genero;
    }

    // Método para imprimir la información de la persona
    public void ImprimirInformacion()
    {
        Console.WriteLine($"Nombre: {this.nombre} {this.apellido}");
        Console.WriteLine($"Edad: {this.edad} años");
        Console.WriteLine($"Género: {this.genero}");
    }
}

class Program // Clase principal que contiene el punto de entrada del programa
{
    static void Main(string[] args)
    {
        // Crear un objeto de tipo Persona con valores predefinidos
        Persona persona1 = new Persona("Juan", "Pérez", 30, "Masculino");

        // Imprimir la información de la persona
        persona1.ImprimirInformacion();

        // Cambiar el nombre y la edad utilizando los métodos de la clase
        persona1.EstablecerNombre("Ana");
        persona1.EstablecerEdad(28);

        // Imprimir la información actualizada de la persona
        Console.WriteLine("\nInformación actualizada:");
        persona1.ImprimirInformacion();
    }
}
