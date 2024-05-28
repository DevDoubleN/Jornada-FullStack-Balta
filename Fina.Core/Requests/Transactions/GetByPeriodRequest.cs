namespace Fina.Core.Requests.Transactions
{
    public class GetByPeriodRequest : PagedRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
