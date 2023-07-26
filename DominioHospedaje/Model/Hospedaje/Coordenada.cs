using DominioHospedaje.Rules;
using Restaurant.SharedKernel.Core;
using Restaurant.SharedKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public record Coordenada : ValueObject
    {
        public double Latitud { get; init; }
        public double Longitud { get; init; }

        public Coordenada(double latitud, double longitud)
        {
            CheckRule(new CoordenadaValida(latitud, longitud));
            Latitud = latitud;
            Longitud = longitud;
        }

        public static implicit operator (double, double)(Coordenada coordenada)
        {
            return (coordenada.Latitud, coordenada.Longitud);
        }
    }

    
}
