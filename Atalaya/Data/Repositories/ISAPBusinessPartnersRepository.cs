using Atalaya.Model;

namespace Atalaya.Data.Repositories
{
    public interface ISAPBusinessPartnersRepository
    {
        Task<Response> UpdateBusinessPartner(SAPBusinessParter sAPBusinessParter);
    }
}
