
namespace AndExteriors.Region1.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Region1/Region"), Route("{action=index}")]
    public class RegionController : Controller
    {
        [PageAuthorize(Region1.PermissionKeys.General)]
        public ActionResult Index()
        {
            return View(MVC.Views.Region1.Region.RegionIndex);
        }
    }
}