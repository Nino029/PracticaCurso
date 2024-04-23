using CursoDomain.Programa1;
using CursoDomain.Programa2;
using CursoDomain.Programa3;
using System.Drawing;


var fechaNacimiento = new DateTime(2003, 4, 20);

Persona persona1 = new Estudiante("Baljeet", "Santiago", "Mecatronica", "2022-1969" , fechaNacimiento);
Console.WriteLine("\n");
Console.WriteLine("======PERSONA:=======");




 persona1.CalcularEdad();
persona1.MostrarInfoPersona();



Estudiante estudiante1 = new Estudiante("Baljeet", "Santiago", "Mecatronica", "2022-1969", fechaNacimiento);
Console.WriteLine("\n");
Console.WriteLine("======ESTUDIANTE:=======");
estudiante1.MostrarEstudiante();



Figura rectangulo = new Rectangulo(10, 20);
Figura circulo = new Circulo(5);
Figura triangulo = new Triangulo(10, 5);
Console.WriteLine("\n");
Console.WriteLine("======AREAS DE LAS FIGURAS:=======");

Console.WriteLine("Área del rectángulo: " + rectangulo.calcularArea());
Console.WriteLine("Área del círculo: " + circulo.calcularArea());
Console.WriteLine("Área del triángulo: " + triangulo.calcularArea());