using System;

namespace AuditoriaApi.Model
{
    public class Auditoria 
    {
        public int Id { get; set; }

        public string Acao { get; set; }

        public string DescricaoAcao { get; set; }

        public string Servico { get; set; }

        public DateTime DataInclusao { get; set; }
    }
}