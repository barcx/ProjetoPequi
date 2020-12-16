using System;

namespace Pequi.Dominio.Entidades.Base
{
    public class EntidadeBase
    {
        public int Id { get; set; }

        public DateTime DataAtualizacao { get; } = DateTime.Now;
    }
}

