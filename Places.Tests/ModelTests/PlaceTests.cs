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
    public void Find_FindLocationInList_ID()
    {
      Place newPlace = new Place("Reno", 3, "Eat at The Golden Flower");
      Place newPlaceTwo = new Place("Tampa", 12, "Go to the MOSI");
      Place placeId = Place.FindItNow(2);
      Assert.AreEqual(1, placeId.Id);
    }
  }

}
