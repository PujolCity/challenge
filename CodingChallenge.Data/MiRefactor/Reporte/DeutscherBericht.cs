using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.MiRefactor.Reporte
{
    public class DeutscherBericht : Reporte
    {
        public DeutscherBericht(List<AbstractFormaGeometrica> formas) : base(formas) { }

        public override string Imprimir()
        {

            if (!formas.Any())
            {
                HeaderListeLeer();
            }
            else
            {
                Header();

                foreach (var forma in formas)
                {
                    forma.Contar(contador);
                }
                Körper();
                Fusszeile();
            }
            return Drucken();
        }

        private void Header()
        {
            this.sb.Append("<h1>Bericht über geometrische Formen</h1>");
        }

        private void HeaderListeLeer()
        {
            this.sb.Append("<h1>Leere Liste geometrischer Formen!</h1>");
        }

        private void Körper()
        {
            //podria darle esta responsabilidad al contador el tema es el idioma
            if (contador.ContadorCuadrados > 0)
            {
                sb.Append($"{contador.ContadorCuadrados} {(contador.ContadorCuadrados == 1 ? "Quadrat" : "Quadrate")} | Bereich {contador.SumaAreaCuadrados:#.##} | Umfang {contador.SumaPerimetrosCuadrados:#.##} <br/>");

            }
            if (contador.ContadorCirculos > 0)
            {
                sb.Append($"{contador.ContadorCirculos} {(contador.ContadorCirculos == 1 ? "Kreis" : "Kreise")} | Bereich {contador.SumaAreaCirculos:#.##} | Umfang {contador.SumaPerimetrosCirculos:#.##} <br/>");

            }
            if (contador.ContadorTriangulos > 0)
            {
                sb.Append($"{contador.ContadorTriangulos} {(contador.ContadorTriangulos == 1 ? "Dreieck" : "Dreiecke")} | Bereich {contador.SumaAreaTriangulos:#.##} | Umfang {contador.SumaPerimetrosTriangulos:#.##} <br/>");

            }
            if (contador.ContadorTrapecios > 0)
            {
                sb.Append($"{contador.ContadorTrapecios} {(contador.ContadorTrapecios == 1 ? "Trapez" : "Trapeze")} | Bereich {contador.SumaAreaTrapecios:#.##} | Umfang {contador.SumaPerimetrosTrapecios:#.##} <br/>");
            }
            if (contador.ContadorRectangulos > 0)
            {
                sb.Append($"{contador.ContadorRectangulos} {(contador.ContadorRectangulos == 1 ? "Rechteck" : "Rechtecke")} | Bereich {contador.SumaAreaRectangulos:#.##} | Umfang {contador.SumaPerimetrosRectangulos:#.##} <br/>");
            }
        }

        private void Fusszeile()
        {
            sb.Append("GESAMT:<br/>");
            sb.Append(contador.ContadorFormas + " " + "formen" + " ");
            sb.Append("Umfang " + (contador.SumaTotalPerimetro).ToString("#.##") + " ");
            sb.Append("Bereich " + (contador.SumaTotalArea).ToString("#.##"));
        }

        private string Drucken()
        {
            return sb.ToString();
        }
    }
}
