using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;
using System;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.Location;
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string nameCity, int daysStayed, string info)
    {
      Place myPlace = new Place(nameCity, daysStayed, info);
      return RedirectToAction("Index");
    }

    // [HttpPost("/places/delete")]
    // public ActionResult DeleteAll()
    // {
    //   Place.ClearAll();
    //   return View();
    // }
  }
}
