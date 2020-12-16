using Pequi.Dominio.Entidades.Base;
using System;

namespace Pequi.Dominio.Entidades

{
    public class Cliente : EntidadeBase
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public DateTime? DataNascimento { get; set; }
    }
}
