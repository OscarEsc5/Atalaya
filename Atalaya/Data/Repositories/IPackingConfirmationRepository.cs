using Atalaya.Model;

namespace Atalaya.Data.Repositories
{
    public interface IPackingConfirmationRepository
    {
        Task<Response> UpdatePackingConfirmation(PackingConfirmation packingConfirmation);
    }
}
