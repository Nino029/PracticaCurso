

namespace CursoDomain.Programa3
{
    public class Circulo: Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double calcularArea()
        {
            return Math.PI * radio * radio;
        }
    }
}
