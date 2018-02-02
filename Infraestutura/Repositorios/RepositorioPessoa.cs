using Dominio.Entidades;
using Dominio.Repositorios;
using System;
using System.Collections.Generic;

namespace Infraestutura.Repositorios
{
    public class RepositorioPessoa : IRepositorioPessoa
    {
        public IList<Pessoa> BuscarTodos()
        {
            return new List<Pessoa>() { new Pessoa("Maria", new DateTime(2014, 6, 14, 6, 32, 0)), new Pessoa("Vanessa", new DateTime(2015, 1, 10, 1, 16, 0)), new Pessoa("Maria", new DateTime(2013, 6, 1, 12, 32, 30)) };
        }
    }
}
