using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciador.Domain;
using SistemaGerenciador.Regras.Interfaces;
using SistemaGerenciador.Regras.Products.Interfaces;

namespace SistemaGerenciador.Regras.Products
{
	public class VisualizarProdutoPorNome : IVisualizarProdutoPorNome
	{
		private readonly IProductRepository _producRepository;

		public VisualizarProdutoPorNome(IProductRepository productRepository)
		{
			_producRepository = productRepository;
		}

		public async Task<IEnumerable<Product>> ExecuteAsync(string name = "")
		{
			return await _producRepository.GetProductsByNameAsync(name);
		}
	}
}
