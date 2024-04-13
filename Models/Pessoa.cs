using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorHotel.Models
{
    class Pessoa
    {
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}
