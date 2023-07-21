using Restaurant.SharedKernel.Core;
using Restaurant.SharedKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public record Comodidad : ValueObject
    {
        public string Value { get; init; }

        public Comodidad(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            Value = value;
        }

        public static implicit operator string(Comodidad comodidad) => comodidad.Value;

        public static implicit operator Comodidad(string comodidad) => new(comodidad);
    }
}
