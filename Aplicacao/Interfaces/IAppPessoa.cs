﻿using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacao.Interfaces
{
    public interface IAppPessoa
    {
        IList<Pessoa> BuscarTodos();
    }
}