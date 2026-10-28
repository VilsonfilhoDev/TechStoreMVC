namespace TechStoreMVC.Models
{
    public class CategoriaDB
    {
        private static readonly List<Categoria> categorias = new()
    {
        new Categoria(1, "Móveis", "Objetos mobiliários."),
        new Categoria(2,"Aparelhos", "Produtos tecnológicos como: Celular, Notebook etc."),
        new Categoria(3,"Computadores Gamers", "Computadores pré-montados."),
        new Categoria(4,"Periféricos", "Produtos de entrada e saída."),
    };

        public List<Categoria> Listar()
        {
            return categorias;
        }

        public Categoria? buscarPorId(int id)
        {
            return categorias.FirstOrDefault(
               categoria => categoria.Id == id
            );
        }
        public void Adicionar(Categoria categoria)
        {
            categoria.Id = categorias.Count == 0 ? 1 : categorias.Max(p => p.Id) + 1;
            categorias.Add(categoria);
        }

        public bool Atualizar(Categoria CategoriaAtualizada)
        {
            Categoria? CategoriaExistente =
            buscarPorId(CategoriaAtualizada.Id);
            if (CategoriaExistente is null)
                return false;

            CategoriaExistente.Nome = CategoriaAtualizada.Nome;
            CategoriaExistente.Descricao = CategoriaAtualizada.Descricao;

            return true;

        }
        public bool Excluir(int id)
        {
            Categoria? categoria = buscarPorId(id);
            if (categoria is null)
                return false;

            categorias.Remove(categoria);

            return true;
        }
    }
}
