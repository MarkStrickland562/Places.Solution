using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string myCityName, string myPhoto, string myDuration, string myCompanion, string myJournalEntry)
    {
      Place myPlace = new Place(myCityName, myPhoto, myDuration, myCompanion, myJournalEntry);
      return RedirectToAction("Index");
    }

  }
}
