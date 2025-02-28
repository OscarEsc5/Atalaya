using Atalaya.Model;

namespace Atalaya.Data.Repositories
{
    public interface IOCConfirmationRepository
    {
        Task<Response> UpdateOCConfirmation(OCConfirmation oCConfirmation);
    }
}
