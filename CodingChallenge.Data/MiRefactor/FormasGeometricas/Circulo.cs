using CodingChallenge.Data.MiRefactor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor
{
    public class Circulo : AbstractFormaGeometrica
    {
        private readonly decimal _diametro;
        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }

        public override void Contar(IFormaGeometricaVisitor visitor)
        {
            visitor.Visitar(this);
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
    }
}
