using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Repositorios
{
    public interface IRepositorioPessoa
    {
        IList<Pessoa> BuscarTodos(); 
    }
}