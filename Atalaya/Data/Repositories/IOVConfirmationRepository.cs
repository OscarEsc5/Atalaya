using Atalaya.Model;

namespace Atalaya.Data.Repositories
{
    public interface IOVConfirmationRepository
    {
        Task<Response> UpdateOVConfirmation(OVConfirmation oVConfirmation);
    }
}
