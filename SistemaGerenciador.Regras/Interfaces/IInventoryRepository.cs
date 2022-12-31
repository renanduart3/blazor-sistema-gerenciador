using SistemaGerenciador.Domain;

namespace SistemaGerenciador.Regras.Interfaces
{

	public interface IInventoryRepository
	{
		Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
		Task AddInventoryAsync(Inventory inventory);
		Task UpdateInventoryAsync(Inventory inventory);
		Task<Inventory> GetInventoryByIdAsync(int inventoryId);
	}

}
