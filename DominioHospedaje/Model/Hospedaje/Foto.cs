using DominioHospedaje.Rules;
using DominioHospedaje.ValueObjects;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Model.Hospedaje
{
    public record Foto : ValueObject
    {
        public string Url { get; init; }

        public Foto(string url)
        {
            CheckRule(new UrlValida(url));
            Url = url;
        }

        public static implicit operator string(Foto foto) => foto.Url;

        public static implicit operator Foto(string url) => new(url);
    }
}
