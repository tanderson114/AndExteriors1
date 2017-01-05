
namespace AndExteriors.Region1
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;
    using System.ComponentModel;

    [EnumKey("Region1.OrderShippingState")]
    public enum OrderShippingState
    {
        [Description("Not Shipped")]
        NotShipped = 0,
        [Description("Shipped")]
        Shipped = 1
    }
}