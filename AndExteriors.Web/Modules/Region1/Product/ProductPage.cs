
namespace AndExteriors.Region1.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Region1/Product"), Route("{action=index}")]
    public class ProductController : Controller
    {
        [PageAuthorize(Region1.PermissionKeys.General)]
        public ActionResult Index()
        {
            return View(MVC.Views.Region1.Product.ProductIndex);
        }
    }
}