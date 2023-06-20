using CodingChallenge.Data.MiRefactor.FormasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor.Visitor
{
    public interface IFormaGeometricaVisitor
    {
        void Visitar(Cuadrado cuadrado);
        void Visitar(Circulo circulo);
        void Visitar(TrianguloEquilatero triangulo);
        void Visitar(Trapecio trapecio);
        void Visitar(Rectangulo rectangulo);
    }
}
