using FluentValidation;
using Pequi.Dominio.Entidades;
using System;

namespace Pequi.Dominio.Validations
{
    public  class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            ValidarNome();
            ValidarEmail();
            ValidarDataNascimento();
        }

        protected void ValidarNome()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Informe o nome.")
                .Length(2, 100).WithMessage("O nome deve ter entre 2 e 100 caracteres.");
        }

        protected void ValidarEmail()
        {
            RuleFor(c => c.Email)
                .NotEmpty()
                .MaximumLength(50)
                .EmailAddress();
        }

        protected void ValidarDataNascimento()
        {
            RuleFor(c => c.DataNascimento)
                .NotEmpty()
                .Must(TemIdadeMinima)
                .WithMessage("O cliente deve ter mais de 18 anos.");
        }

        protected static bool TemIdadeMinima(DateTime? birthDate)
        {
            return birthDate <= DateTime.Now.AddYears(-18);
        }
    }
}
