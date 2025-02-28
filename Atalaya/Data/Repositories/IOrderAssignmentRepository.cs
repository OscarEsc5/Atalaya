using Atalaya.Model;

namespace Atalaya.Data.Repositories
{
    public interface IOrderAssignmentRepository
    {
        Task<Response> UpdateOrderAssignment(OrderAssignment orderAssignment);
    }
}
