using SimplesAPI.Models;

namespace SimplesAPI.Repositories
{
    public class ProdutoRepository
    {

        private readonly List<Produto> _produtos;

        public ProdutoRepository()
        {
            _produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Produto A", Preco = 10.00m },
                new Produto { Id = 2, Nome = "Produto B", Preco = 20.00m },
                new Produto { Id = 3, Nome = "Produto C", Preco = 30.00m },
                new Produto { Id = 4, Nome = "Produto D", Preco = 40.00m },
                new Produto { Id = 5, Nome = "Produto E", Preco = 50.00m },
                new Produto { Id = 6, Nome = "Produto F", Preco = 60.00m }
            };
        }

        public IEnumerable<Produto> GetAll() => _produtos;

        public Produto GetById(int id) => _produtos.FirstOrDefault(p => p.Id == id);

        public void Add(Produto produto) => _produtos.Add(produto);

        public void Update(Produto produto)
        {
            var existingProduto = GetById(produto.Id);
            if (existingProduto != null)
            {
                existingProduto.Nome = produto.Nome;
                existingProduto.Preco = produto.Preco;
            }
        }

        public void Delete(int id)
        {
            var produto = GetById(id);
            if (produto != null)
                _produtos.Remove(produto);
        }

    }
}
