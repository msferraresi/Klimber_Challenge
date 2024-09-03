using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometricaAbstract
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

        public override decimal CalcularArea() => ((_baseMayor + _baseMenor) * _altura) / 2;
        public override decimal CalcularPerimetro() => _baseMayor + _baseMenor + 2 * _altura; // Simplificación asumiendo lados laterales iguales
        public override string ObtenerNombre(int idioma)
        {
            switch (idioma)
            {
                case Idiomas.Castellano:
                    return "Trapecio";
                case Idiomas.Ingles:
                    return "Trapezoid";
                case Idiomas.Italiano:
                    return "Trapezio";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
