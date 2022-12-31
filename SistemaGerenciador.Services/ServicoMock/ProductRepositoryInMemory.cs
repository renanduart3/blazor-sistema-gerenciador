using SistemaGerenciador.Domain;
using SistemaGerenciador.Regras.Interfaces;

namespace SistemaGerenciador.Services.ServicoMock
{
	public class ProductRepositoryInMemory : IProductRepository
	{
		private readonly List<Product> _products;
		public ProductRepositoryInMemory()
		{
			_products = new List<Product>()
			{
				new Product { Id = 1, Name = "Seat" },
				new Product { Id = 2, Name = "Body", },
				new Product { Id = 3, Name = "Wheel" },
				new Product { Id = 4, Name = "Pedel"},
				new Product { Id = 5, Name = "Sharkoon"},
			};
		}
		public Task AddProductAsync(Product product)
		{
			if (_products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return Task.CompletedTask;
			_products.Add(product);

			var maxInv = _products.Max(x => x.Id);
			product.Id = maxInv + 1;

			return Task.CompletedTask;
		}

		public Task<Product> GetProductByIdAsync(int productId)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Product>> GetProductsByNameAsync(string name)
		{
			if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_products);

			return _products.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
		}

		public Task UpdateProductAsync(Product product)
		{
			throw new NotImplementedException();
		}
	}
}
