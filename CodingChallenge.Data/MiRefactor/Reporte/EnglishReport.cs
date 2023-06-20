using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor.Reporte
{
    public class EnglishReport : Reporte
    {
        public EnglishReport(List<AbstractFormaGeometrica> formas) : base(formas) { }

        public override string Imprimir()
        {

            if (!formas.Any())
            {
                EmptyListHeader();
            }
            else
            {
                Header();

                foreach (var forma in this.formas)
                {
                    forma.Contar(contador);
                }
                Body();
                Footer();
            }
            return Print();
        }

        private void Header()
        {
            this.sb.Append("<h1>Shapes report</h1>");
        }

        private void EmptyListHeader()
        {
            this.sb.Append("<h1>Empty list of shapes!</h1>");
        }

        private void Body()
        {
            if (contador.ContadorCuadrados > 0)
            {
                sb.Append($"{contador.ContadorCuadrados} {(contador.ContadorCuadrados == 1 ? "Square" : "Squares")} | Area {contador.SumaAreaCuadrados:#.##} | Perimeter {contador.SumaPerimetrosCuadrados:#.##} <br/>");

            }
            if (contador.ContadorCirculos > 0)
            {
                sb.Append($"{contador.ContadorCirculos} {(contador.ContadorCirculos == 1 ? "Circle" : "Circles")} | Area {contador.SumaAreaCirculos:#.##} | Perimeter {contador.SumaPerimetrosCirculos:#.##} <br/>");

            }
            if (contador.ContadorTriangulos > 0)
            {
                sb.Append($"{contador.ContadorTriangulos} {(contador.ContadorTriangulos == 1 ? "Triangle" : "Triangles")} | Area {contador.SumaAreaTriangulos:#.##} | Perimeter {contador.SumaPerimetrosTriangulos:#.##} <br/>");

            }
            if (contador.ContadorTrapecios > 0)
            {
                sb.Append($"{contador.ContadorTrapecios} {(contador.ContadorTrapecios == 1 ? "Trapezoid" : "Trapezoids")} | Area {contador.SumaAreaTrapecios:#.##} | Perimeter {contador.SumaPerimetrosTrapecios:#.##} <br/>");
            }
            if (contador.ContadorRectangulos > 0)
            {
                sb.Append($"{contador.ContadorRectangulos} {(contador.ContadorRectangulos == 1 ? "Rectangle" : "Rectangles")} | Area {contador.SumaAreaRectangulos:#.##} | Perimeter {contador.SumaPerimetrosRectangulos:#.##} <br/>");
            }
        }

        private void Footer()
        {
            // FOOTER
            sb.Append("TOTAL:<br/>");
            sb.Append(contador.ContadorFormas + " " + "shapes" + " ");
            sb.Append("Perimeter " + (contador.SumaTotalPerimetro).ToString("#.##") + " ");
            sb.Append("Area " + (contador.SumaTotalArea).ToString("#.##"));
        }

        private string Print()
        {
            return sb.ToString();
        }
    }
}
