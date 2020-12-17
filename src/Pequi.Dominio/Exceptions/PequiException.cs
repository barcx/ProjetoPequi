using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pequi.Dominio.Exceptions
{
    public class PequiException : Exception
    {
        public PequiException(string message)
           : base(message) { }
    }
}
