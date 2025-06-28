using System.Xml.Serialization;

public class Agenda
{
    Persona[] personas;
    int capacidad;
    public Agenda(int max)
    {
        capacidad = max;
        personas = new Persona[capacidad];
    }

    public void agregarPersona(Persona p, int posicion)
    {
        personas[posicion] = p;
    }

    public void imprimirPersona(int posicion)
    {
        System.Console.WriteLine("+++++Agenda++++++");
        personas[posicion].imprimir();
    }
}