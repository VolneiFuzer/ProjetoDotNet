using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDotNet.Dominio.Entidades
{
    public class Atividade
    {
        public int PessoaID { get; set; }
        public int AtividadeID { get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }

        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFinal { get; set; }

        public TipoDeAtividade Tipo { get; set; }
        public string DescricaoAtividade { get; set; }

        public string DescicaoProblema { get; set; }
        public string DescicaoSolucao { get; set; }


    }

    public enum TipoDeAtividade
    {
        Analise, Requisitos, Desenvolvimento, Teste, Implantacao
    }
}
