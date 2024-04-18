namespace CursoDomain.Programa1
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string ciudad;

        public Persona(string nombre, int edad,  string ciudad)
        {
            this.nombre = nombre;
            this.edad=edad;
            this.ciudad=ciudad;
            

        }


        public void MostrarInfoPersona()
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Ciudad: {ciudad}");
        }

        
        public void CalcularEdad()
        {
            Console.WriteLine($"Edad de {edad} años");

        }

      
        




    }
}
