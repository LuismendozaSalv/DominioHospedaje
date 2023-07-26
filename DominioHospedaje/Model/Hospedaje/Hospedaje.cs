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
        public int CapacidadMaxima { get; private set; }
        public int NumeroHabitaciones { get; private set; }
        public int NumeroCamas { get; private set; }
        public Precio Precio { get; private set; }
        public TipoHospedaje TipoHospedaje { get; private set; } 
        public Ciudad Ciudad { get; private set; }
        public Coordenada Coordenada { get; private set; }
        private readonly IList<Comodidad> _comodidades;
        public IEnumerable<Comodidad> Comodidades => _comodidades;

        private readonly IList<Foto> _fotos;
        public IEnumerable<Foto> Fotos => _fotos;
        public Guid UsuarioID { get; private set; }

        internal Hospedaje(string titulo, string descripcion, Direccion direccion,int capacidadMaxima, int numeroHabitaciones, 
            int numeroCamas, int tipoHospedaje, Coordenada coordenada, string codigoPostal, 
            decimal precio, Ciudad ciudad, Guid usuarioId)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Descripcion = descripcion;
            Direccion = direccion;
            CapacidadMaxima = capacidadMaxima;
            NumeroHabitaciones = numeroHabitaciones;
            NumeroCamas = numeroCamas;
            TipoHospedaje = (TipoHospedaje)tipoHospedaje;
            Coordenada = coordenada;
            Ciudad = ciudad;
            CodigoPostal = codigoPostal;
            Precio = precio;
            UsuarioID = usuarioId;
            _comodidades = new List<Comodidad>();
            _fotos = new List<Foto>();
        }

        public void AgregarComodidad(string value)
        {
            if (_comodidades.Any(comodidad => comodidad.Value == value))
            {
                throw new ArgumentException("La comodidad ya existe");
            }
            _comodidades.Add(value);
        }

        public void AgregarFoto(string url)
        {
            if (_fotos.Any(foto => foto.Url == url))
            {
                throw new ArgumentException("La foto ya existe");
            }
            _fotos.Add(url);
        }
    }
}
