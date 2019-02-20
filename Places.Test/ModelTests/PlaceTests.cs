using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;
using System.Collections.Generic;
using System;

namespace Places.Tests
{
  [TestClass]
  public class PlaceTest
  {
    [TestMethod]
    // Verify that an instance of Place can be created.
    public void PlaceConstructor_CreatesInstanceOfPlace()
    {
      //Arrange
      string myPlace = "seattle";
      Place newPlace = new Place(myPlace);

      //Act
      Type myPlaceType = typeof(Place);
      Type newPlaceType = newPlace.GetType();

      //Assert
      Assert.AreEqual(myPlaceType, newPlaceType);
    }

    [TestMethod]
    // Verify that the Place getter method returns the value of the Place.
    public void GetPlace_ReturnsPlace_String()
    {
      //Arrange
      string myPlace = "seattle";
      Place newPlace = new Place(myPlace);

      //Act
      string result = newPlace.GetPlace();

      //Assert
      Assert.AreEqual(myPlace, result);
    }

    [TestMethod]
    // Verify that the Place setter method can update the value of the Place.
    public void SetPlace_SetPlace_String()
    {
      //Arrange
      string myPlace = "seattle";
      Place newPlace = new Place(myPlace);

      //Act
      string updatedPlace = "portland";
      newPlace.SetPlace(updatedPlace);
      string result = newPlace.GetPlace();

      //Assert
      Assert.AreEqual(updatedPlace, result);
    }



  }
}
