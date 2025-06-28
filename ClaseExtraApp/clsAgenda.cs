public class Agenda
{
    Persona[] personas;
    int capacidad;
    public Agenda(int max)
    {
        capacidad = max;
        personas = new Persona[capacidad];
    }
}