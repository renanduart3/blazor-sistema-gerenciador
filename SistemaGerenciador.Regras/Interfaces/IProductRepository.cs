using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciador.Domain;

namespace SistemaGerenciador.Regras.Interfaces
{
	public interface IProductRepository
	{

		Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
		Task AddProductAsync(Product product);
		Task UpdateProductAsync(Product product);
		Task<Product> GetProductByIdAsync(int productId);
	}
}
