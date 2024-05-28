using Fina.Core.Models;
using Fina.Core.Requests.Transactions;
using Fina.Core.Responses;

namespace Fina.Core.Handlers
{
    internal interface ITransactionHandler
    {
        Task<Response<Transaction?>> CreateAsync(CreateRequest request);
        Task<Response<Transaction?>> UpdateAsync(UpdateRequest request);
        Task<Response<Transaction?>> DeleteAsync(DeleteRequest request);
        Task<Response<Transaction?>> GetByIdAsync(GetByIdRequest request);
        Task<PagedResponse<Transaction>?> GetByPeriodAsync(GetByPeriodRequest request);
    }
}
