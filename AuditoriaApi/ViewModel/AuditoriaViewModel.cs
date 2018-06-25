using System;
using System.ComponentModel.DataAnnotations;

namespace AuditoriaApi.ViewModel
{
    public class AuditoriaViewModel 
    {
        [Required]
        public string Acao { get; set; }

        public string DescricaoAcao { get; set; }

        [Required]
        public string Servico { get; set; }        
    }
}