using Serenity.Services;

namespace AndExteriors.Region1
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}