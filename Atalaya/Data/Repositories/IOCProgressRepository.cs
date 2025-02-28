using Atalaya.Model;

namespace Atalaya.Data.Repositories
{
    public interface IOCProgressRepository
    {
        Task<Response> UpdateOCProgress(OCProgress oCProgress);
    }
}
