using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.ValueObjects
{
    public record Precio : ValueObject
    {
        public decimal Value { get; init; }

        public Precio(decimal value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("El precio no puede ser cero");
            }
            Value = value;
        }

        public static implicit operator decimal(Precio precio) => precio.Value;
        
        public static implicit operator Precio(decimal value) => new(value);
    }
}
