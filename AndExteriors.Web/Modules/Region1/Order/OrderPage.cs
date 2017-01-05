

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Region1/Order", url: "~/Region1/Order", permission: "Region1")]

namespace AndExteriors.Region1.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Region1/Order"), Route("{action=index}")]
    public class OrderController : Controller
    {
        [PageAuthorize(Region1.PermissionKeys.General)]
        public ActionResult Index()
        {
            return View(MVC.Views.Region1.Order.OrderIndex);
        }
    }
}