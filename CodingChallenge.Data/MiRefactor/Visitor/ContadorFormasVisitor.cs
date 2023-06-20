using CodingChallenge.Data.MiRefactor.FormasGeometricas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor.Visitor
{
    public class ContadorFormasVisitor : IFormaGeometricaVisitor
    {
        public int ContadorCuadrados { get; private set; }
        public int ContadorCirculos { get; private set; }
        public int ContadorTriangulos { get; private set; }
        public int ContadorTrapecios { get; private set; }
        public int ContadorRectangulos { get; private set; }
        public int ContadorFormas { get; private set; }

        public decimal SumaPerimetrosCuadrados { get; private set; }
        public decimal SumaPerimetrosCirculos { get; private set; }
        public decimal SumaPerimetrosTriangulos { get; private set; }
        public decimal SumaPerimetrosTrapecios { get; private set; }
        public decimal SumaPerimetrosRectangulos { get; private set; }

        public decimal SumaAreaCuadrados { get; private set; }
        public decimal SumaAreaCirculos { get; private set; }
        public decimal SumaAreaTriangulos { get; private set; }
        public decimal SumaAreaTrapecios { get; private set; }
        public decimal SumaAreaRectangulos { get; private set; }

        public decimal SumaTotalArea { get => this.SumaAreaTriangulos + this.SumaAreaCirculos + this.SumaAreaCuadrados + this.SumaAreaTrapecios + this.SumaAreaRectangulos; }
        public decimal SumaTotalPerimetro { get => this.SumaPerimetrosTriangulos + this.SumaPerimetrosCirculos + this.SumaPerimetrosCuadrados + this.SumaPerimetrosTrapecios + this.SumaPerimetrosRectangulos; }


        public void Visitar(Cuadrado cuadrado)
        {
            ContadorFormas++;
            ContadorCuadrados++;
            SumaAreaCuadrados += cuadrado.CalcularArea();
            SumaPerimetrosCuadrados += cuadrado.CalcularPerimetro();
        }

        public void Visitar(Circulo circulo)
        {
            ContadorFormas++;
            ContadorCirculos++;
            SumaAreaCirculos += circulo.CalcularArea();
            SumaPerimetrosCirculos += circulo.CalcularPerimetro();
        }

        public void Visitar(TrianguloEquilatero triangulo)
        {
            ContadorFormas++;
            ContadorTriangulos++;
            SumaAreaTriangulos += triangulo.CalcularArea();
            SumaPerimetrosTriangulos += triangulo.CalcularPerimetro();
        }

        public void Visitar(Trapecio trapecio)
        {
            ContadorFormas++;
            ContadorTrapecios++;
            SumaAreaTrapecios = +trapecio.CalcularArea();
            SumaPerimetrosTrapecios = +trapecio.CalcularPerimetro();
        }

        public void Visitar(Rectangulo rectangulo)
        {
            ContadorFormas++;
            ContadorRectangulos++;
            SumaPerimetrosRectangulos += rectangulo.CalcularPerimetro();
            SumaAreaRectangulos += rectangulo.CalcularArea();
        }
    }
}
