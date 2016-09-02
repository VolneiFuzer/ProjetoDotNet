using System.Collections.Generic;

namespace ProjetoDotNet.Dominio.Entidades
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Minicurriculo { get; set; }

        public IEnumerable<Telefone> Telefones { get; set; }

        public Endereco Endereco { get; set; }

        public IEnumerable<Atividade> Atividades { get; set; }

    }
}
