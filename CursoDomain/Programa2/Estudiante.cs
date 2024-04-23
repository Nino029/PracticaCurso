
using CursoDomain.Programa1;

namespace CursoDomain.Programa2
{

    public class Estudiante : Persona
    {
         private string Carrera;
         private string Matricula;
        
         
       


        public Estudiante( string nombre,string ciudad, string carrera, string matricula, DateTime fechaDeNacimiento) : base(nombre, ciudad, fechaDeNacimiento)
        {
            
            Carrera = carrera;
            Matricula = matricula;

        }

        public override void MostrarInfoPersona()
        {
            base.MostrarInfoPersona();
          
        }

        public  void MostrarEstudiante()
        {
            base.MostrarInfoPersona();
            Console.WriteLine($"Carrera: {Carrera}, Matrícula: {Matricula}");
        }


    }



}
