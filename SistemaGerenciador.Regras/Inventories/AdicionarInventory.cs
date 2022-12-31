using SistemaGerenciador.Domain;
using SistemaGerenciador.Regras.Interfaces;
using SistemaGerenciador.Regras.Inventories.Interfaces;

namespace SistemaGerenciador.Regras.Inventories
{
    public class AdicionarInventory : IAdicionarInventory
	{
		private readonly IInventoryRepository _inventoryRepository;

		public AdicionarInventory(IInventoryRepository inventoryRepository)
		{
			_inventoryRepository = inventoryRepository;
		}
		public async Task ExecuteAsync(Inventory inventory)
        {
			await _inventoryRepository.AddInventoryAsync(inventory);
		}
    }
}
