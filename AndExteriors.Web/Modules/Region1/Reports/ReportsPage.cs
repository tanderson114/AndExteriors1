
namespace AndExteriors.Region1.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Region1/Reports"), Route("{action=index}")]
    public class ReportsController : Controller
    {
        [PageAuthorize(Region1.PermissionKeys.General)]
        public ActionResult Index()
        {
            return View(MVC.Views.Common.Reporting.ReportPage,
                new ReportRepository().GetReportTree("Region1"));
        }
    }
}