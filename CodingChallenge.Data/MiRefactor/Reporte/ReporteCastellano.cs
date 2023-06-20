using CodingChallenge.Data.MiRefactor.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor.Reporte
{
    public class ReporteCastellano : Reporte
    {
        public ReporteCastellano(List<AbstractFormaGeometrica> formas) : base(formas) { }

        public override string Imprimir()
        {

            if (!formas.Any())
            {
                EncabezadoListaVacia();
            }
            else
            {
                Encabezado();

                foreach (var forma in formas)
                {
                    forma.Contar(contador);
                }
                Cuerpo();
                PieDePagina();
            }
            return Print();
        }

        private void Encabezado()
        {
            this.sb.Append("<h1>Reporte de Formas</h1>");
        }

        private void EncabezadoListaVacia()
        {
            this.sb.Append("<h1>Lista vacía de formas!</h1>");
        }

        private void Cuerpo()
        {
            //podria darle esta responsabilidad al contador el tema es el idioma
            if (contador.ContadorCuadrados > 0)
            {
                sb.Append($"{contador.ContadorCuadrados} {(contador.ContadorCuadrados == 1 ? "Cuadrado" : "Cuadrados")} | Area {contador.SumaAreaCuadrados:#.##} | Perimetro {contador.SumaPerimetrosCuadrados:#.##} <br/>");

            }
            if (contador.ContadorCirculos > 0)
            {
                sb.Append($"{contador.ContadorCirculos} {(contador.ContadorCirculos == 1 ? "Círculo" : "Círculos")} | Area {contador.SumaAreaCirculos:#.##} | Perimetro {contador.SumaPerimetrosCirculos:#.##} <br/>");

            }
            if (contador.ContadorTriangulos > 0)
            {
                sb.Append($"{contador.ContadorTriangulos} {(contador.ContadorTriangulos == 1 ? "Triángulo" : "Triángulos")} | Area {contador.SumaAreaTriangulos:#.##} | Perimetro {contador.SumaPerimetrosTriangulos:#.##} <br/>");

            }
            if (contador.ContadorTrapecios > 0)
            {
                sb.Append($"{contador.ContadorTrapecios} {(contador.ContadorTrapecios == 1 ? "Trapecio" : "Trapecios")} | Area {contador.SumaAreaTrapecios:#.##} | Perimetro {contador.SumaPerimetrosTrapecios:#.##} <br/>");
            }
            if (contador.ContadorRectangulos > 0)
            {
                sb.Append($"{contador.ContadorRectangulos} {(contador.ContadorRectangulos == 1 ? "Retangulo" : "Rectangulos")} | Area {contador.SumaAreaRectangulos:#.##} | Perimetro {contador.SumaPerimetrosRectangulos:#.##} <br/>");
            }
        }

        private void PieDePagina()
        {
            // FOOTER
            sb.Append("TOTAL:<br/>");
            sb.Append(contador.ContadorFormas + " " + "formas" + " ");
            sb.Append("Perimetro " + (contador.SumaTotalPerimetro).ToString("#.##") + " ");
            sb.Append("Area " + (contador.SumaTotalArea).ToString("#.##"));

        }

        private string Print()
        {
            return sb.ToString();
        }
    }
}
