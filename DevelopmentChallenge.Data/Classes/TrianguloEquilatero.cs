using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometricaAbstract
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 3;
        public override string ObtenerNombre(int idioma)
        {
            switch (idioma)
            {
                case Idiomas.Castellano:
                    return "Triángulo";
                case Idiomas.Ingles:
                    return "Triangle";
                case Idiomas.Italiano:
                    return "Triangolo";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
