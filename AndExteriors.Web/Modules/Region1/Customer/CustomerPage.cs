
namespace AndExteriors.Region1.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Region1/Customer"), Route("{action=index}")]
    public class CustomerController : Controller
    {
        [PageAuthorize(Region1.PermissionKeys.Customer.View)]
        public ActionResult Index()
        {
            return View(MVC.Views.Region1.Customer.CustomerIndex);
        }
    }
}