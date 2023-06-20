using CodingChallenge.Data.MiRefactor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor.FormasGeometricas
{
    public class Rectangulo : AbstractFormaGeometrica
    {
        private readonly decimal _lado1;
        private readonly decimal _lado2;

        public Rectangulo(decimal baseRectangulo, decimal alturaRectangulo)
        {
            if (baseRectangulo == alturaRectangulo)
                throw new ArgumentException("Los lados de un rectángulo deben ser distintos");

            _lado1 = baseRectangulo;
            _lado2 = alturaRectangulo;
        }

        public override decimal CalcularArea()
        {
            return _lado1 * _lado2;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado1 * 2 + _lado2 * 2;
        }

        public override void Contar(IFormaGeometricaVisitor visitor)
        {
            visitor.Visitar(this);
        }
    }
}
