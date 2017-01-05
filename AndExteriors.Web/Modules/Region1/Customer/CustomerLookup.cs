
namespace AndExteriors.Region1.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript("Region1.Customer")]
    public class CustomerLookup : RowLookupScript<CustomerRow>
    {
        public CustomerLookup()
        {
            IdField = CustomerRow.Fields.CustomerID.PropertyName;
            TextField = CustomerRow.Fields.CompanyName.PropertyName;
        }
    }
}