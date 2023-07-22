using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public class Pais : Entity
    {
        public Guid PaisId { get; private set; }
        public string Nombre { get; private set; }
        public string CodigoPais { get; private set; }

        internal Pais(Guid paisId, string nombre, string codigoPais)
        {
            PaisId = paisId;
            Nombre = nombre;
            CodigoPais = codigoPais;
        }
    }
}
