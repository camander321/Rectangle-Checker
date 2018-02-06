using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using RectangleChecker.Models;

namespace RectangleChecker.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

  }
}
