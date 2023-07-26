using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioHospedaje.Rules
{
    public class UrlValida : IBussinessRule
    {
        private readonly string _url;
        public string Message => "La url es inválida";

        public UrlValida(string url)
        {
            _url = url;
        }
        public bool IsValid()
        {
            if (Uri.TryCreate(_url, UriKind.Absolute, out Uri uriResult))
            {

                return !string.IsNullOrEmpty(uriResult.Scheme);
            }
            return false;
        }
    }     
}
