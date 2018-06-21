using System;
using System.Collections.Generic;
using System.Linq;
using AuditoriaApi.Model;

namespace AuditoriaApi.Repositorio
{
    public static class Repositorio 
    {
        public static IEnumerable<Auditoria> GetAuditorias()
        {
            List<Auditoria> _auditoriaList = new List<Auditoria>{
                new Auditoria {
                    Id = 1,
                    Acao = "Pagamento",
                    DescricaoAcao = "Cartao validade e pagamento efetuado.",
                    DataInclusao = DateTime.Now.Date.AddDays(-2),
                    Servico = "PagamentoApi"
                },
                new Auditoria {
                    Id = 2,
                    Acao = "Pagamento",
                    DescricaoAcao = "Cartao invalido e pagamento nao efetuado.",
                    DataInclusao = DateTime.Now.Date.AddDays(-1),
                    Servico = "PagamentoApi"
                },
                new Auditoria {
                    Id = 3,
                    Acao = "Autenticacao",
                    DescricaoAcao = "Usuario autenticado com sucesso. TokenUsuario = primeiroToken",
                    DataInclusao = DateTime.Now.Date.AddDays(-1),
                    Servico = "AutenticacaoApi"
                }
            };

            return _auditoriaList;
        }

        public static Auditoria GetAuditoria(int id)
        {
            return GetAuditorias().FirstOrDefault(u => u.Id == id);
        }
    }
}