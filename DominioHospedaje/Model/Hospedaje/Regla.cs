using Restaurant.SharedKernel.Core;
using Restaurant.SharedKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public record Regla : ValueObject
    {
        public string Value { get; init; }

        public Regla(string value)
        {
            CheckRule(new StringNotNullOrEmptyRule(value));
            Value = value;
        }

        public static implicit operator string(Regla regla) => regla.Value;

        public static implicit operator Regla(string regla) => new(regla);
    }
}
