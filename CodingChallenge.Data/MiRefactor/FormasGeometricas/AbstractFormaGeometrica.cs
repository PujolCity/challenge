using CodingChallenge.Data.MiRefactor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor
{
    public abstract class AbstractFormaGeometrica
    {
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract void Contar(IFormaGeometricaVisitor visitor);

    }
}
