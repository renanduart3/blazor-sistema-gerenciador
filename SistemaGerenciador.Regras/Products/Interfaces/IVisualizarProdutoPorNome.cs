using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGerenciador.Domain;

namespace SistemaGerenciador.Regras.Products.Interfaces
{
	public interface IVisualizarProdutoPorNome
	{
		Task<IEnumerable<Product>> ExecuteAsync(string name = "");
	}
}
