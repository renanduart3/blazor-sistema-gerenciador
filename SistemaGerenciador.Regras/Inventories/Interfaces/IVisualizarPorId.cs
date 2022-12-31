using SistemaGerenciador.Domain;

namespace SistemaGerenciador.Regras.Inventories.Interfaces
{
    public interface IVisualizarPorId
    {
        Task<Inventory> ExecuteAsync(int inventoryId);
    }
}