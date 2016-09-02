namespace ProjetoDotNet.Dominio.Entidades
{
    public class Telefone
    {
        public int PessoaID { get; set; }
        public string Numero { get; set; }
        public TipoDeTelefone Tipo { get; set; }
    }

    public enum TipoDeTelefone
    {
        Residencial, Celular, Contato, Comercial
    }
}
