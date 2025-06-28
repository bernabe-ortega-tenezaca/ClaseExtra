public class Persona
{
    //Propiedades
    public string cedula { get; set; }
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string lugarNacimiento { get; set; }
    //Metodos

    public void imprimir()
    {
        Console.WriteLine($"Nombres: {nombre} {apellido} \ncedula:{cedula} \nLugar de nacimiento: {lugarNacimiento}");
        System.Console.WriteLine();
    }

    public void imprimirNombres()
    {
        Console.WriteLine($"Nombres: {apellido} {nombre}");
        System.Console.WriteLine();
    }

    //Constructor

    /// <summary>
    /// Clase Persona
    /// </summary>
    /// <param name="Cedula">De tipo string para la cédula</param>
    /// <param name="Nombre">De tipo string para los nombres</param>
    /// <param name="Apellido">De tipo string para los apellidos</param>
    /// <param name="LugarNacimiento">De tipo string para el Lugar donde nacio</param>
    public Persona(string Cedula, string Nombre, string Apellido, string LugarNacimiento)
    {
        cedula = Cedula;
        nombre = Nombre;
        apellido = Apellido;
        lugarNacimiento = LugarNacimiento;
    }
    //Destructor
}