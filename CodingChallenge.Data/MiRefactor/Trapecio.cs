using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor
{
    // TRAPECIO ISOSCELES 
    public class Trapecio : IFormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
        }

        public decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) / 2) * _altura;
        }

        public decimal CalcularPerimetro()
        {
            decimal ladoOblicuo = CalcularLadoOblicuo();
            return _baseMayor + _baseMenor + (ladoOblicuo * 2);
        }

        private decimal CalcularLadoOblicuo()
        {
            decimal diferenciaBases = (_baseMayor - _baseMenor) / 2;
            decimal ladoOblicuo = (decimal)Math.Sqrt((double)((diferenciaBases * diferenciaBases) + (_altura * _altura)));
            return ladoOblicuo;
        }
    }
}
