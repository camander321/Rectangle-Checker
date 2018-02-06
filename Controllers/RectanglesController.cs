using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using RectangleChecker.Models;

namespace RectangleChecker.Controllers
{
  public class RectanglesController : Controller
  {
    [HttpGet("/rectangles/createform")]
    public ActionResult Index()
    {
      return View("CreateForm");
    }

    [HttpGet("/rectangles/result")]
    public ActionResult Result()
    {
      Rectangle myRectangle = new Rectangle(Int32.Parse(Request.Query["side-length"]), Int32.Parse(Request.Query["side-width"]));
      return View("Result", myRectangle);
    }
  }
}
