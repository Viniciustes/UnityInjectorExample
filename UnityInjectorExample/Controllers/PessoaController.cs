using Aplicacao.Interfaces;
using System.Web.Mvc;

namespace UnityInjectorExample.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IAppPessoa _appPessoa;

        public PessoaController(IAppPessoa appPessoa)
        {
            _appPessoa = appPessoa;
        }

        public ActionResult Index()
        {
            return View(_appPessoa.BuscarTodos());
        }
    }
}