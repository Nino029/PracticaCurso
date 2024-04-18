

namespace CursoDomain.Programa3
{
    public class Rectangulo : Figura
    {
        private double ancho;
        private double alto;

        public Rectangulo(double ancho, double alto)
        {

            this.ancho = ancho;
            this.alto = alto;

        }
        public override double calcularArea() { return this.ancho * this.alto;}

    }
}
