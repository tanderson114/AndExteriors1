

//[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Region1/OrderDetail", url: "~/Region1/OrderDetail", permission: "Region1")]

namespace AndExteriors.Region1.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Region1/OrderDetail"), Route("{action=index}")]
    public class OrderDetailController : Controller
    {
        [PageAuthorize(Region1.PermissionKeys.General)]
        public ActionResult Index()
        {
            return View(MVC.Views.Region1.OrderDetail.OrderDetailIndex);
        }
    }
}