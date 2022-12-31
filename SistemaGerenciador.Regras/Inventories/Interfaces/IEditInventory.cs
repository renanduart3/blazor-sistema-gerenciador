using SistemaGerenciador.Domain;

namespace SistemaGerenciador.Regras.Inventories.Interfaces
{
	public interface IEditInventory
	{
		Task ExecuteAsync(Inventory inventory);
	}
}