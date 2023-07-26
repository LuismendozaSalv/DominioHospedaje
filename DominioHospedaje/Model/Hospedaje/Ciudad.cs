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
        public Pais Pais { get; private set; }

        internal Ciudad(Guid ciudadId, string nombre, Pais pais)
        {
            CiudadId = Guid.NewGuid();
            Nombre = nombre;
            Pais = pais;
        }
    }
}
