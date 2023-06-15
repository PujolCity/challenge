using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _diametro;
        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);

        }

        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
    }
}
