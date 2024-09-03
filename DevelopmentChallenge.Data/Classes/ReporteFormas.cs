using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public static class ReporteFormas
    {
        public static string Imprimir(List<FormaGeometricaAbstract> formas, int idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                switch (idioma)
                {
                    case Idiomas.Castellano:
                        sb.Append("<h1>Lista vacía de formas!</h1>");
                        break;
                    case Idiomas.Ingles:
                        sb.Append("<h1>Empty list of shapes!</h1>");
                        break;
                    case Idiomas.Italiano:
                        sb.Append("<h1>Elenco vuoto di forme!</h1>");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                switch (idioma)
                {
                    case Idiomas.Castellano:
                        sb.Append("<h1>Reporte de Formas</h1>");
                        break;
                    case Idiomas.Ingles:
                        sb.Append("<h1>Shapes report</h1>");
                        break;
                    case Idiomas.Italiano:
                        sb.Append("<h1>Rapporto delle Forme</h1>");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                var resumenPorForma = formas
                    .GroupBy(f => f.GetType())
                    .Select(g => new
                    {
                        Tipo = g.First().ObtenerNombre(idioma),
                        Cantidad = g.Count(),
                        Area = g.Sum(f => f.CalcularArea()),
                        Perimetro = g.Sum(f => f.CalcularPerimetro())
                    });

                foreach (var resumen in resumenPorForma)
                {
                    sb.Append($"{resumen.Cantidad} {resumen.Tipo} | Area {resumen.Area:#.##} | Perimetro {resumen.Perimetro:#.##} <br/>");
                }

                sb.Append("TOTAL:<br/>");
                sb.Append($"{formas.Count} {(idioma == Idiomas.Castellano ? "formas" : idioma == Idiomas.Ingles ? "shapes" : "forme")} ");
                sb.Append($"{(idioma == Idiomas.Castellano ? "Perimetro" : idioma == Idiomas.Ingles ? "Perimeter" : "Perimetro")} {resumenPorForma.Sum(r => r.Perimetro):#.##} ");
                sb.Append($"Area {resumenPorForma.Sum(r => r.Area):#.##}");
            }

            return sb.ToString();
        }
    }
}
