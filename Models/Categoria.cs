namespace TechStoreMVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;


        // O MVC usa este construtor para receber o formulário.
        // Tivemos de alterar o construtor para que tratassemos o erro ao editar
        public Categoria()
        {
        }

        public Categoria(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }
}
