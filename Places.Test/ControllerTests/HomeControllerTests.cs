using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Controllers;
using Places.Models;

namespace Places.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
    //Arrange
    HomeController controller = new HomeController();

    //Act
    ActionResult indexView = controller.Index();

    //Assert
    Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
      public void Index_HasCorrectModelType_PlaceList()
      {
      //Arrange
      ViewResult indexView = new HomeController().Index() as ViewResult;

      //Act
      var result = indexView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(result, typeof(List<Place>));
      }

      [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      //Arrange
      PlacesController controller = new PlacesController();

      //Act
      IActionResult view = controller.Create("Some Place");

      //Assert
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
      //Arrange
      PlacesController controller = new PlacesController();
      RedirectToActionResult actionResult = controller.Create("Some Place") as RedirectToActionResult;

      //Act
      string result = actionResult.ActionName;

      //Assert
      Assert.AreEqual(result, "Index");
    }

  }
}
