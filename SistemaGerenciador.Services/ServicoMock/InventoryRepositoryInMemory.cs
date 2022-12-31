using SistemaGerenciador.Domain;
using SistemaGerenciador.Regras.Interfaces;

namespace SistemaGerenciador.Services.ServicoMock
{
	public class InventoryRepositoryInMemory : IInventoryRepository
	{
		private readonly List<Inventory> _inventories;

		public InventoryRepositoryInMemory()
		{
			_inventories = new List<Inventory>()
			{
				new Inventory { Id = 1, Name = "Bike Seat", Quantity = 10, Price = 2 },
				new Inventory { Id = 2, Name = "Bike Body", Quantity = 10, Price = 15 },
				new Inventory { Id = 3, Name = "Bike Wheel", Quantity = 20, Price = 8 },
				new Inventory { Id = 4, Name = "Bike Pedel", Quantity = 20, Price = 1 }
			};

		}
		public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
		{
			if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

			return _inventories.Where(x => x.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
		}
		public Task AddInventoryAsync(Inventory inventory)
		{
			if (_inventories.Any(x => x.Name.Equals(inventory.Name, StringComparison.OrdinalIgnoreCase))) return Task.CompletedTask;

			_inventories.Add(inventory);

			var maxInv = _inventories.Max(x => x.Id);
			inventory.Id = maxInv + 1;

			return Task.CompletedTask;
		}

		public async Task<Inventory> GetInventoryByIdAsync(int inventoryId)
		{
			var inventory = _inventories.First(x => x.Id.Equals(inventoryId));
			var newInventory = new Inventory
			{
				Id = inventory.Id,
				Name = inventory.Name,
				Price = inventory.Price,
				Quantity = inventory.Quantity
			};
			return await Task.FromResult(newInventory);
		}

		public Task UpdateInventoryAsync(Inventory inventory)
		{
			//if (_inventories.Any(x => x.Id == inventory.Id && x.Name.Equals(inventory.Name, StringComparison.OrdinalIgnoreCase)))
			//	return Task.CompletedTask;

			var inv = _inventories.FirstOrDefault(x => x.Id == inventory.Id);

			if (inv != null)
			{
				inv.Name = inventory.Name;
				inv.Price = inventory.Price;
				inv.Quantity = inventory.Quantity;
			}

			return Task.CompletedTask;
		}

	}
}
