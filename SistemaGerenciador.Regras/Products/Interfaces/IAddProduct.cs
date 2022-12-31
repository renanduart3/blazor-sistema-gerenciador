using SistemaGerenciador.Domain;

namespace SistemaGerenciador.Regras.Products.Interfaces
{
	public interface IAddProduct
	{
		Task ExecuteAsync(Product product);
	}
}
