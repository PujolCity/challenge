using CodingChallenge.Data.Classes;
using CodingChallenge.Data.MiRefactor;
using CodingChallenge.Data.MiRefactor.FormasGeometricas;
using CodingChallenge.Data.MiRefactor.Reporte;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Tests
{
    [TestClass]
    public class TestMiRefactor
    {
        [TestMethod]
        public void TestResumenListaVacia()
        {
            var formas = new List<AbstractFormaGeometrica>();
            var reporteCastellano = new ReporteCastellano(formas).Imprimir();

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", reporteCastellano);
        }

        [TestMethod]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var formas = new List<AbstractFormaGeometrica>();
            var report = new EnglishReport(formas).Imprimir();

            Assert.AreEqual("<h1>Empty list of shapes!</h1>", report);
        }

        [TestMethod]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<AbstractFormaGeometrica> { new Cuadrado(5) };
            var reporteCastellano = new ReporteCastellano(cuadrados);
            var reporte = reporteCastellano.Imprimir();

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", reporte);
        }

        [TestMethod]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<AbstractFormaGeometrica>
            {
                new Cuadrado (5),
                new Cuadrado (1),
                new Cuadrado (3)
            };
            var report = new EnglishReport(cuadrados).Imprimir();

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", report);
        }

        [TestMethod]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<AbstractFormaGeometrica>
            {
                new Cuadrado (5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };
            var report = new EnglishReport(formas).Imprimir();

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                report);
        }

        [TestMethod]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<AbstractFormaGeometrica>
            {
                new Cuadrado (5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };
            var reporte = new ReporteCastellano(formas).Imprimir();

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                reporte);
        }

        // ### TEST IDIOMA ALEMAN ###

        [TestMethod]
        public void TestResumenListaVaciaFormasAleman()
        {
            var formas = new List<AbstractFormaGeometrica>();
            var report = new DeutscherBericht(formas).Imprimir();

            Assert.AreEqual("<h1>Leere Liste geometrischer Formen!</h1>", report);
        }

        [TestMethod]
        public void TestResumenListaConUnRectangulo()
        {
            var rectangulos = new List<AbstractFormaGeometrica> { new Rectangulo(5, 7) };
            var reporteAleman = new DeutscherBericht(rectangulos);
            var reporte = reporteAleman.Imprimir();

            Assert.AreEqual("<h1>Bericht über geometrische Formen</h1>1 Rechteck | Bereich 35 | Umfang 24 <br/>GESAMT:<br/>1 formen Umfang 24 Bereich 35", reporte);
        }

        [TestMethod]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<AbstractFormaGeometrica> { new Trapecio(7, 5, 5) };
            var reporteAleman = new DeutscherBericht(trapecios);
            var reporte = reporteAleman.Imprimir();

            Assert.AreEqual("<h1>Bericht über geometrische Formen</h1>1 Trapez | Bereich 30 | Umfang 22,2 <br/>GESAMT:<br/>1 formen Umfang 22,2 Bereich 30", reporte);
        }

        [TestMethod]
        public void TestResumenListaConMasFormas()
        {
            var formas = new List<AbstractFormaGeometrica>
            {
                new Cuadrado (5),
                new Rectangulo (10, 4.2m),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new Rectangulo (10, 17),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m),
                new Trapecio (15, 12, 10),
            };
            var report = new DeutscherBericht(formas).Imprimir();

            Assert.AreEqual(
                "<h1>Bericht über geometrische Formen</h1>2 Quadrate | Bereich 29 | Umfang 28 <br/>2 Kreise | Bereich 13,01 | Umfang 18,06 <br/>3 Dreiecke | Bereich 49,64 | Umfang 51,6 <br/>1 Trapez | Bereich 135 | Umfang 47,22 <br/>2 Rechtecke | Bereich 212 | Umfang 82,4 <br/>GESAMT:<br/>10 formen Umfang 227,29 Bereich 438,65",
                report);
        }
    }
}
