Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine();

//clase Persona
//mipersona es un objeto
Persona mipersona = new Persona("0606060606", "Ana Lucia", "Gómez Alamo", "Puyo");
Persona mipersona1 = new Persona("232345662", "Juan Carlos", "Haro Valdez", "Miami");


mipersona.cedula = "1234567890";
mipersona.lugarNacimiento = "Tena";

mipersona.imprimir();
mipersona1.imprimirNombres();

// System.Console.WriteLine(mipersona.cedula);
// System.Console.WriteLine(mipersona.nombre);
// System.Console.WriteLine(mipersona.apellido);
// System.Console.WriteLine(mipersona.lugarNacimiento);

// System.Console.WriteLine(mipersona1.nombre);

// Ciudadano miciudadano = new Ciudadano("0603234567", "Ana", "Perez", "Ambato");

// System.Console.WriteLine(miciudadano.getCedula());

// //Pruebas de mensajes en consola

// string nombre = "Carlos"; //inicializo la variable nombre
// string materia = "Quimica";

// //Concatenar mensajes
// Console.WriteLine("Hola " + nombre + " bienvenido.");
// Console.WriteLine("Hola {0} bienvenido {1}", nombre, "a la programación");
// Console.WriteLine("Hola {0} bienvenido a {1}", nombre, materia);
// Console.WriteLine($"Hola {nombre} bienvenido a {materia}!");

// //Lecturas desde teclado
// string ciudad;
// System.Console.WriteLine("Ingrese una ciudad");
// ciudad = Console.ReadLine();
// System.Console.WriteLine("La ciudad es: " + ciudad);