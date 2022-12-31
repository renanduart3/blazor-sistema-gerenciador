using SistemaGerenciador.Domain;

namespace SistemaGerenciador.Regras.Inventories.Interfaces
{
    public interface IAdicionarInventory
	{
		Task ExecuteAsync(Inventory inventory);

	}
}