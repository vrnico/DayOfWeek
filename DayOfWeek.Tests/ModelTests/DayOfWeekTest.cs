using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOfWeek.Models;
using System;
using System.Collections.Generic;

namespace DayOfWeek.Tests
{
  [TestClass]
  public class DayOfWeekTest
  {
    [TestMethod]
    public void GetDay_ReturnDay()
    {
        //arrange
        List<int> testDay = new List<int> {2018, 02, 15};
        DayOfWeekGenerator newDWG = new DayOfWeekGenerator(2018, 02, 15);

        //act
        List<int> dateInput = new List<int> {newDWG.GetYear(), newDWG.GetMonth(), newDWG.GetDay()};
        //assert
        CollectionAssert.AreEqual(testDay, dateInput);
    }
  }
}
