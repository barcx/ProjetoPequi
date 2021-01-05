using FluentValidation.Results;
using System;

namespace Pequi.Dominio.Entidades.Base
{
    public abstract class Entidade
    {
        public int Id { get; set; }

        public DateTime DataAtualizacao { get; } = DateTime.Now;

        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();
    }
}

