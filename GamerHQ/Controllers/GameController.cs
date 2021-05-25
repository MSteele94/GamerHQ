using GamerHQ_Models.GameModels;
using GamerHQ_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamerHQ.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            var service = new GameService();
            var model = service.GetGames();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GameCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateGameService();
            if (service.CreateGame(model))
            {
                TempData["SaveResult"] = "The game was created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Game could not be created.");
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var svc = CreateGameService();
            var model = svc.GetGameById(id);
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var service = CreateGameService();
            var detail = service.GetGameById(id);
            var model =
                new GameEdit
                {
                    GameID = detail.GameID,
                    GameName = detail.GameName,
                    Genres = detail.Genres,
                    CreatedUtc = detail.CreatedUtc,
                    //Games = detail.Games,
                };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GameEdit model)
        {
            if (!ModelState.IsValid) return View(model);
            if (model.GameID != id)
            {
                ModelState.AddModelError("", "Id Mismatch");
                return View(model);
            }
            var service = CreateGameService();

            if (service.UpdateGame(model))
            {
                TempData["SaveResult"] = "Your game was updated.";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Your game could not be updated.");
            return View(model);
        }
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateGameService();
            var model = svc.GetGameById(id);
            return View(model);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateGameService();

            service.DeleteGame(id);

            TempData["SaveResult"] = "Your game was deleted";

            return RedirectToAction("Index");
        }
        private GameService CreateGameService()
        {
            var service = new GameService();
            return service;
        }
    }
}