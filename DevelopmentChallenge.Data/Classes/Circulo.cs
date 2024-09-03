using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometricaAbstract
    {
        private readonly decimal _radio;

        public Circulo(decimal radio)
        {
            _radio = radio;
        }

        public override decimal CalcularArea() => (decimal)Math.PI * _radio * _radio;
        public override decimal CalcularPerimetro() => 2 * (decimal)Math.PI * _radio;
        public override string ObtenerNombre(int idioma)
        {
            switch (idioma)
            {
                case Idiomas.Castellano:
                    return "Círculo";
                case Idiomas.Ingles:
                    return "Circle";
                case Idiomas.Italiano:
                    return "Cerchio";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
