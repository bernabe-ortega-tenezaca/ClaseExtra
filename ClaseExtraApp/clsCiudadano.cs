public class Ciudadano
{
    //Propiedades o atributos
    private string cedula;
    private string nombres;
    private string apellidos;
    private string lugarNacimiento;

    //métodos
    public void setCedula(string Cedula)
    {
        cedula = Cedula;
    }

    public string getCedula()
    {
        return cedula;
    }


    //Constructor
    public Ciudadano(string _Cedula, string _Nombre, string _Apellidos, string _LugarNacimiento)
    {
        cedula = _Cedula;
        nombres = _Nombre;
        apellidos = _Apellidos;
        lugarNacimiento = _LugarNacimiento;
    }

}