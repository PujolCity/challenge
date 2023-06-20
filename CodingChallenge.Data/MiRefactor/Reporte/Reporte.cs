using CodingChallenge.Data.MiRefactor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor.Reporte
{
    public abstract class Reporte
    {
        protected List<AbstractFormaGeometrica> formas;
        protected StringBuilder sb;
        protected ContadorFormasVisitor contador;

        public Reporte(List<AbstractFormaGeometrica> formas)
        {
            this.formas = formas;
            sb = new StringBuilder();
            contador = new ContadorFormasVisitor();
        }
        public abstract string Imprimir();

    }
}
