using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pim2019v1.Controllers
{
    public class HomeController : Controller
    {
        private readonly Models.universidadeEntities universidade;

        public HomeController()
        {
            universidade = new Models.universidadeEntities();
        }

        ~HomeController()
        {
            universidade.Dispose();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string cod)
        {
            return View(universidade.Turma.Where(x => x.codigo.StartsWith(cod)).OrderBy(x => x.codigo));
        }
    }
}