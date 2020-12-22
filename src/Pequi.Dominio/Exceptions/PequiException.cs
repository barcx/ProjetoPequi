using System;
using System.Runtime.Serialization;

namespace Pequi.Dominio.Exceptions
{
    [Serializable]
    public class PequiException : Exception
    {
        public PequiException()
           : this("Erro ao executar procedimento referente ao negócio.") { }

        public PequiException(string message)
           : base(message) { }
        protected PequiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
