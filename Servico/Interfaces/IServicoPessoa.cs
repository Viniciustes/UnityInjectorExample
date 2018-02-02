using Dominio.Entidades;
using System.Collections.Generic;

namespace Servico.Interfaces
{
    public interface IServicoPessoa
    {
        IList<Pessoa> BuscarTodos();
    }
}