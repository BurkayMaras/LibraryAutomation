using DataAccess;
using System.Linq;
using System.Web.Mvc;

namespace KutuphaneOtomasyonu.Controllers
{
    public class KategoriController : Controller
    {

        // GET: Kategori
        public ActionResult Index()
        {
            Context context = new Context();
            var model = context.Yazarlar.ToList();
            return View();
        }
    }
}