using Fina.Core.Models;
using Fina.Core.Requests.Categories;
using Fina.Core.Responses;

namespace Fina.Core.Handlers
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>> CreateAsync(CreateRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateRequest request);
        Task<Response<Category?>> DeleteAsync(DeleteRequest request);
        Task<Response<Category?>> GetByIdAsync(GetByIdRequest request);
        Task<PagedResponse<List<Category>?>> GetAllAsync(GetAllRequest request);
    }
}
