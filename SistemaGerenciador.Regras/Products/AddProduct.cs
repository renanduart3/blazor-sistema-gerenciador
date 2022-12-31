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
	public class AddProduct: IAddProduct
	{
		private readonly IProductRepository _productRepository;


		public AddProduct(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task ExecuteAsync(Product product)
		{
			await _productRepository.AddProductAsync(product);
		}
	}
}
