using Atalaya.Model;

namespace Atalaya.Data.Repositories
{
    public interface ILockTransferRepository
    {
        Task<Response> CreateLockTransfer(LockTransfer lockTransfer);
    }
}
