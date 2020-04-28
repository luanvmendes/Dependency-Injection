using System.Collections.Generic;
using DI.Models;

namespace DI.Services
{
    public interface IFormaPagamentoService
    {
        IEnumerable<FormaPagamento> GetFormaPagamento();
    }
}