using DominioHospedaje.ValueObjects;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public class Hospedaje : AggregateRoot
    {
        public string Titulo { get; private set; }
        public string Descripcion { get; private set; }
        public Direccion Direccion { get; private set; }
        public string CodigoPostal { get; private set; }
        public Precio Precio { get; private set; }
        public IList<Comodidad> Comodidades { get; private set; }
        public Guid UsuarioID { get; private set; }
    }
}
