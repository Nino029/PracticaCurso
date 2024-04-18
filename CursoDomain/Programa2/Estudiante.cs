
using CursoDomain.Programa1;

namespace CursoDomain.Programa2
{

    public class Estudiante : Persona
    {
         private string carrera;
         private string matricula;


        public Estudiante( string nombre, int edad, string ciudad, string carrera, string matricula) : base(nombre, edad, ciudad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.ciudad = ciudad;
            this.carrera = carrera;
            this.matricula = matricula; 

        }

        public void MostrarInfoEstudiante()
        {
           
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Ciudad: {ciudad}, Carrera: {carrera}, Matrícula: {matricula}");
        }




    }



}
