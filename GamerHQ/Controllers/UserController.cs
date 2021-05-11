﻿using GamerHQ_Models.UserModels;
using GamerHQ_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamerHQ.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(string searchBy, int? search)
        {
            var service = new UserService();
            var model = service.GetUsers();
            if (searchBy == "Age")
            {
                return View(model.Where(x => x.Age == search));
            }
            else
            {
                return View(model);
            }
        }
        //Get
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var service = CreateUserService();
            if (service.CreateUser(model))
            {
                TempData["SaveResult"] = "Your account was created.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Account could not be created.");
            return View(model);
        }
        public ActionResult Details(int id)
        {
            var svc = CreateUserService();
            var model = svc.GetUserById(id);
            return View(model);
        }
        public ActionResult Edit(int id)
        {
            var service = CreateUserService();
            var detail = service.GetUserById(id);
            var model =
                new UserEdit
                {
                    UserID = detail.UserID,
                    Name = detail.Name,
                    GamerTag = detail.GamerTag,
                    Email = detail.Email,
                    Age = detail.Age
                };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UserEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            //if (model.UserID != id)
            //{
            //    ModelState.AddModelError("", "Id Mismatch");
            //    return View(model);
            //}
            var service = CreateUserService();

            if (service.UpdateUser(model))
            {
                TempData["SaveResult"] = "Your account was updated";
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("", "Your account could not be updated.");
            return View(model);
        }
        [ActionName("Delete")]
        public ActionResult Delete(int id)
        {
            var svc = CreateUserService();
            var model = svc.GetUserById(id);
            return View(model);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = CreateUserService();
            service.DeleteUser(id);
            TempData["SaveResult"] = "Your account was deleted.";

            return RedirectToAction("Index");
        }
        private UserService CreateUserService()
        {
            var service = new UserService();
            return service;
        }
    }
}