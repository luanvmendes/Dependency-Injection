using DI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DI.Controllers
{
    [ApiController]        
    [Route("/")]
    public class DependencyInjectionController : ControllerBase
    {
        private readonly IFormaPagamentoService _formaPagamento;

        //injetando a dependência no construtor da controller
        public DependencyInjectionController(IFormaPagamentoService formaPagamento)
        {
            _formaPagamento = formaPagamento;
        }

        public IActionResult Index()
        {
            //utilizando a instância do serviço
            var formaPgto = _formaPagamento.GetFormaPagamento();
            return Ok(formaPgto);
        }
    }
}