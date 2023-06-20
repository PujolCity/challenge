using CodingChallenge.Data.MiRefactor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor
{
    public class Cuadrado : AbstractFormaGeometrica
    {
        private readonly decimal _lado;
        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public override void Contar(IFormaGeometricaVisitor visitor)
        {
            visitor.Visitar(this);

        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
