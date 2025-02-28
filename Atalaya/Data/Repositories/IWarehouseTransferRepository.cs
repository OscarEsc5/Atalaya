using Atalaya.Model;

namespace Atalaya.Data.Repositories
{
    public interface IWarehouseTransferRepository
    {
        Task<Response> CreateWarehouseTransfer(WarehouseTransfer warehouseTransfer);
    }
}
