using SistemaGerenciador.Domain;
using SistemaGerenciador.Regras.Interfaces;
using SistemaGerenciador.Regras.Inventories.Interfaces;

namespace SistemaGerenciador.Regras.Inventories
{
	public class VisualizarPorId : IVisualizarPorId
	{
		private readonly IInventoryRepository _inventoryRepository;

		public VisualizarPorId(IInventoryRepository inventoryRepository)
		{
			_inventoryRepository = inventoryRepository;
		}
		public async Task<Inventory> ExecuteAsync(int inventoryId)
		{
			return await _inventoryRepository.GetInventoryByIdAsync(inventoryId);
		}
	}
}
