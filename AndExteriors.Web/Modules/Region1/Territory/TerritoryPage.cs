
namespace AndExteriors.Region1.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Region1/Territory"), Route("{action=index}")]
    public class TerritoryController : Controller
    {
        [PageAuthorize(Region1.PermissionKeys.General)]
        public ActionResult Index()
        {
            return View(MVC.Views.Region1.Territory.TerritoryIndex);
        }
    }
}