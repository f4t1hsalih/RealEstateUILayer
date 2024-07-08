using System.Web.Mvc;

namespace RealEstateUILayer.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}