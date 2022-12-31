using SistemaGerenciador.Domain;
using SistemaGerenciador.Regras.Interfaces;
using SistemaGerenciador.Regras.Inventories.Interfaces;

namespace SistemaGerenciador.Regras.Inventories
{
	public class EditInventory : IEditInventory
	{
		private readonly IInventoryRepository _inventoryRepository;

		public EditInventory(IInventoryRepository inventoryRepository)
		{
			_inventoryRepository = inventoryRepository;
		}
		public async Task ExecuteAsync(Inventory inventory)
		{
			await _inventoryRepository.UpdateInventoryAsync(inventory);
		}
	}
}
