namespace CursoDomain.Programa1
{
    public  abstract class Persona
    {
    
        public string _Nombre { get ; set; }
        private int _Edad { get ; set ; }
        public string _Ciudad { get; set; }

        public DateTime _fechaDeNacimiento { get; set; }

        public Persona(string nombre, string ciudad, DateTime fechaDeNacimiento)
        {
            _Nombre = nombre;
            _fechaDeNacimiento = fechaDeNacimiento;
            _Ciudad=ciudad;
            

        }


        public  virtual void MostrarInfoPersona()
        {
            Console.WriteLine($"Nombre: {_Nombre}, Edad: {CalcularEdad()}, Ciudad: {_Ciudad}");
        }

        
        public  virtual int CalcularEdad ()
        {
           _Edad= DateTime.Now.Year - _fechaDeNacimiento.Year;

            return _Edad;

        }

      
        




    }
}
