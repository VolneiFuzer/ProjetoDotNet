using ProjetoDotNet.Dominio.Entidades;
using System.Data.Entity;

namespace ProjetoDotNet.Infra.Contexto
{
	public class ContextoDoProjeto : DbContext
	{

		public DbSet <Pessoa> Pessoa{ get; set; }
		public DbSet <Atividade> Atividades { get; set; }
		public DbSet <Endereco> Endereco { get; set; }
		public DbSet <Telefone> Telefone { get; set; }

		public ContextoDoProjeto() : base("ProjetoDotNet")
		{

		}
	}
}
