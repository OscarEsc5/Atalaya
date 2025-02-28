using Atalaya.Model;

namespace Atalaya.Data.Repositories
{
    public interface IInventoryAdjustmentsRepository
    {
        Task<Response> CreateInventoryAdjustments(InventoryAdjustments inventoryAdjustments);
    }
}
