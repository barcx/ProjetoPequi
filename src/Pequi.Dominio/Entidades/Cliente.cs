using Pequi.Dominio.Entidades.Base;
using Pequi.Dominio.Validations;
using System;

namespace Pequi.Dominio.Entidades

{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime? DataNascimento { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new ClienteValidator().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
