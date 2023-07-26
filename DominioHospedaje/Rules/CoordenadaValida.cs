using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Rules
{
    public class CoordenadaValida : IBussinessRule
    {
        private readonly double _latitud;
        private readonly double _longitud;

        public string Message => "La coordenada no es válida";

        public CoordenadaValida(double latitud, double longitud)
        {
            _latitud = latitud;
            _longitud = longitud;
        }
        public bool IsValid()
        {
            if (_latitud >= -90 && _latitud <= 90)
            {
                if (_longitud >= -180 && _longitud <= 180)
                {             
                    return true;
                }
            }
            return false; 
        }
    }
}
