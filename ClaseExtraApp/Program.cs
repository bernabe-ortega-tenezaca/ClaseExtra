Console.WriteLine("Universidad Estatal Amazónica");
Console.WriteLine();

//Pruebas de mensajes en consola

string nombre = "Carlos"; //inicializo la variable nombre
string materia = "Quimica";

//Concatenar mensajes
Console.WriteLine("Hola " + nombre + " bienvenido.");
Console.WriteLine("Hola {0} bienvenido {1}", nombre, "a la programación");
Console.WriteLine("Hola {0} bienvenido a {1}", nombre, materia);
Console.WriteLine($"Hola {nombre} bienvenido a {materia}!");