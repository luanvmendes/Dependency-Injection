using System.Collections.Generic;
using DI.Models;

namespace DI.Services
{
    public class FormaPagamentoService : IFormaPagamentoService
    {
        public IEnumerable<FormaPagamento> GetFormaPagamento()
        {
            return new List<FormaPagamento>
            {
                new FormaPagamento {Id = 1, formaPagamento = "Boleto"},
                new FormaPagamento {Id = 2, formaPagamento = "Cartão de crédito"},
                new FormaPagamento {Id = 3, formaPagamento = "Cartão de débito"},
                new FormaPagamento {Id = 4, formaPagamento = "Transferência Online"}
            };
        }
    }
}