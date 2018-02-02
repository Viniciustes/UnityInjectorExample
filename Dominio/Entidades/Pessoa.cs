using System;

namespace Dominio.Entidades
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
    }
}