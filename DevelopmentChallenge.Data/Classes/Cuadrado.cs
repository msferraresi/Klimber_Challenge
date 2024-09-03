using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometricaAbstract
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea() => _lado * _lado;
        public override decimal CalcularPerimetro() => _lado * 4;
        public override string ObtenerNombre(int idioma)
        {
            switch (idioma)
            {
                case Idiomas.Castellano:
                    return "Cuadrado";
                case Idiomas.Ingles:
                    return "Square";
                case Idiomas.Italiano:
                    return "Quadrato";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
