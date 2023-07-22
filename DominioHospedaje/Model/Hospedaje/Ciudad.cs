using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public class Ciudad : Entity
    {
        public Guid CiudadId { get; private set; }
        public string Nombre { get; private set; }
        public Guid PaisId { get; private set; }

        internal Ciudad(Guid ciudadId, string nombre, Guid paisId)
        {
            CiudadId = ciudadId;
            Nombre = nombre; 
            PaisId = paisId;
        }
    }
}
