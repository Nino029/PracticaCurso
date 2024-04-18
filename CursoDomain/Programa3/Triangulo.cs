

namespace CursoDomain.Programa3
{
    public  class Triangulo : Figura
    {

        private double baseTriangulo;
        private double altura;

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override double calcularArea()
        {
            return baseTriangulo * altura / 2;
        }
    }
}
