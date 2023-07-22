using Restaurant.SharedKernel.Core;
using Restaurant.SharedKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public record Direccion : ValueObject
    {
        public string Calle { get; init; }
        public string Avenida { get; init; }
        public int Numero { get; init; }
        public Guid CiudadId { get; init; }

        internal Direccion(string calle, string avenida, int numero, Guid ciudadId)
        {
            CheckRule(new StringNotNullOrEmptyRule(calle));
            CheckRule(new StringNotNullOrEmptyRule(avenida));
            CheckRule(new NotNegativeRule(numero));
            Calle = calle;
            Avenida = avenida;
            Numero = numero;
            CiudadId = ciudadId;
        }
    }
}
