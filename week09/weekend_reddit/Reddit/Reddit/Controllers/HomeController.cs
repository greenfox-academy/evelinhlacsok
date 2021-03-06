﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;

namespace Reddit.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private ContentRepository ContentRepository;

        public HomeController(ContentRepository contentRepository)
        {
            ContentRepository = contentRepository;
        }

        [Route("")]
      //  [Route("list")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(ContentRepository.GetList());
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string content)
        {
            ContentRepository.AddPost(content);
            return RedirectToAction("index");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            ContentRepository.DeletePost(id);
            return RedirectToAction("index");
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            var content = ContentRepository.GetId(id);
            return View(content);
        }

        [Route("/{id}/edit")]
        [HttpPost]
        public IActionResult Edit(Content content)
        {
            ContentRepository.Update(content);
            return RedirectToAction("index");
        }

        [Route("vote/plus/{id}")]
        public IActionResult UpVote(int id)
        {
            ContentRepository.Vote(id, "plus");
            return RedirectToAction("index");
        }

        [Route("vote/minus/{id}")]
        public IActionResult DownVote(int id)
        {
            ContentRepository.Vote(id, "minus");
            return RedirectToAction("index");
        }
    }
}
