using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Avenida { get; set; }
        public int Numero { get; set; }
        public Guid CiudadId { get; set; }
    }
}
