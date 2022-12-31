using SistemaGerenciador.Domain;
using SistemaGerenciador.Regras.Interfaces;
using SistemaGerenciador.Regras.Inventories.Interfaces;

namespace SistemaGerenciador.Regras.Inventories
{
    public class VisualizarPorNome : IVisualizarPorNome
	{
		private readonly IInventoryRepository _inventoryRepository;

		public VisualizarPorNome(IInventoryRepository inventoryRepository)
		{
			_inventoryRepository = inventoryRepository;
		}
		public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
			return await _inventoryRepository.GetInventoriesByNameAsync(name);
		}
    }
}
