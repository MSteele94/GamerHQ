using GamerHQ_Models.JoiningTableModels;
using GamerHQ_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamerHQ.Controllers
{
    public class JoiningTableController : Controller
    {
        // GET: JoiningTable
        public ActionResult Index()
        {
            
            return View();
        }
        private JoiningTableService CreateJoiningTableService()
        {
            var joiningTableService = new JoiningTableService();
            return joiningTableService;
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(JoiningCreate addGamesToUsers)
        {
            if (!ModelState.IsValid) return View(addGamesToUsers);

            var service = CreateJoiningTableService();
            if (service.CreateJoiningTable(addGamesToUsers))
            {
                TempData["SaveResult"] = "You added a game to your account";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Game could not be added to account.");
            return View(addGamesToUsers);
        }
    }
}