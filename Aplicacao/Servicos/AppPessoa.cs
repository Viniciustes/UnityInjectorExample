using System.Collections.Generic;
using Aplicacao.Interfaces;
using Dominio.Entidades;
using Servico.Interfaces;

namespace Aplicacao.Servicos
{
    public class AppPessoa : IAppPessoa
    {
        private readonly IServicoPessoa _servicoPessoa;

        public AppPessoa(IServicoPessoa servicoPessoa)
        {
            _servicoPessoa = servicoPessoa;
        }

        public IList<Pessoa> BuscarTodos()
        {
            return _servicoPessoa.BuscarTodos();
        }
    }
}