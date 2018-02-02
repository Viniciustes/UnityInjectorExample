using Dominio.Entidades;
using Dominio.Repositorios;
using Servico.Interfaces;
using System;
using System.Collections.Generic;

namespace Servico.Servicos
{
    public class ServicoPessoa : IServicoPessoa
    {
        private readonly IRepositorioPessoa _repositorioPessoa;

        public ServicoPessoa(IRepositorioPessoa repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }

        public IList<Pessoa> BuscarTodos()
        {
            return _repositorioPessoa.BuscarTodos();
        }
    }
}