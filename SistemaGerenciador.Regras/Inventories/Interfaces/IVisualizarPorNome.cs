using SistemaGerenciador.Domain;

namespace SistemaGerenciador.Regras.Inventories.Interfaces
{
    public interface IVisualizarPorNome
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");

    }
}