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
        private readonly IList<Comodidad> _comodidades;
        public IEnumerable<Comodidad> Comodidades => _comodidades;
        public Guid UsuarioID { get; private set; }

        internal Hospedaje(string titulo, string descripcion, Direccion direccion, string codigoPostal, decimal precio, Guid usuarioId)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Direccion = direccion;
            CodigoPostal = codigoPostal;
            Precio = precio;
            UsuarioID = usuarioId;
            _comodidades = new List<Comodidad>();
        }

        public void AgregarComodidad(string value)
        {
            if (_comodidades.Any(comodidad => comodidad.Value == value))
            {
                throw new ArgumentException("La comodidad ya existe");
            }
            _comodidades.Add(value);
        }
    }
}
