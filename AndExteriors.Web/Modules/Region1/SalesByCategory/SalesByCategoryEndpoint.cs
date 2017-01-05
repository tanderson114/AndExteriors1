
namespace AndExteriors.Region1.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.SalesByCategoryRepository;
    using MyRow = Entities.SalesByCategoryRow;

    [RoutePrefix("Services/Region1/SalesByCategory"), Route("{action}")]
    [ConnectionKey("Region1"), ServiceAuthorize("Region1:General")]
    public class SalesByCategoryController : ServiceEndpoint
    {
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
