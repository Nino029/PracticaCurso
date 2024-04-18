using CursoDomain.Programa1;
using CursoDomain.Programa2;
using CursoDomain.Programa3;
using System.Drawing;




Persona persona1 = new Persona("Baljeet", 19, "Santiago");
Console.WriteLine("\n");
Console.WriteLine("======PERSONA:=======");

persona1.MostrarInfoPersona();
persona1.CalcularEdad();




Estudiante estudiante1 = new Estudiante("Baljeet", 19, "Santiago", "Mecatronica", "2022-1969");
Console.WriteLine("\n");
Console.WriteLine("======ESTUDIANTE:=======");
estudiante1.MostrarInfoEstudiante();



Figura rectangulo = new Rectangulo(10, 20);
Figura circulo = new Circulo(5);
Figura triangulo = new Triangulo(10, 5);
Console.WriteLine("\n");
Console.WriteLine("======AREAS DE LAS FIGURAS:=======");

Console.WriteLine("Área del rectángulo: " + rectangulo.calcularArea());
Console.WriteLine("Área del círculo: " + circulo.calcularArea());
Console.WriteLine("Área del triángulo: " + triangulo.calcularArea());