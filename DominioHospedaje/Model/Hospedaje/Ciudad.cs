using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public class Ciudad
    {
        public Guid CiudadId { get; set; }
        public string Nombre { get; set; }
        public Guid PaisId { get; set; }
    }
}
