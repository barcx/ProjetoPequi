using System;

namespace Pequi.Dominio.Exceptions
{
    public class PequiException : Exception
    {
        public PequiException(string message)
           : base(message) { }
    }
}
