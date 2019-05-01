using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Controllers;
using Places.Models;

namespace Places.Tests
{
    [TestClass]
    public class PlacesControllerTest
    {
      [TestMethod]
      public void AddCrew_AddPersonToPlaceObject_Crew()
      {
        List<Place> location = new ListPlace{};
        Crew newCrew = new Crew("Jason");

        string newPerson = location.AddCrew(1);

        Assert.AreEqual( , newPerson)

      }
    }

}
