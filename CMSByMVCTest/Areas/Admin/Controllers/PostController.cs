using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMSByMVCTest.Models;

namespace CMSByMVCTest.Areas.Admin.Controllers
{

    [RouteArea("Admin")]
    [RoutePrefix("post")]
    public class PostController : Controller
    {
        //
        // GET: /Admin/Post/
        public ActionResult Index()
        {
            return View();
        }


        //admin/post/create/
        [Route("create")]
        [HttpGet]
        public ActionResult Create()
        {
            var model = new Post();
            return View(model);
        }

        //admin/post/create/
        [Route("create")]
        [HttpPost]
        public ActionResult Create(Post model) {
            if (!ModelState.IsValid) {
                return View(model);
            }

            //update model in data store
            return RedirectToAction("index");
        }


        //admin/post/edit/post-to-edit
        [Route("edit/{id}")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var model = new Post();

            return View(model);
        }


        //admin/post/edit/post-to-edit
        [Route("edit/{id}")]
        [HttpPost]
        public ActionResult Edit(Post model) {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //update model in data store
            return RedirectToAction("index");

        }
	}
}