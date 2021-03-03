using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using CarDealership.Models;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests : IDisposable
  {
    public void Dispose()
    {
        Car.ClearAll();
    }

    [TestMethod]
    public void CarConstructor_CreatesInstanceOfCar_Car()
    {
        Car newCar = new Car();
        Assert.AreEqual(newCar.GetType(), typeof(Car));
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_CarList()
    {
        List<Car> newList = new List<Car> {};
        List<Car> result = Car.GetAll();
        CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsCars_CarList()
    {
        Car newCar1 = new Car();
        Car newCar2 = new Car();
        List<Car> newCarList = new List<Car>{newCar1, newCar2};
        List<Car> result = Car.GetAll();
        CollectionAssert.AreEqual(result, newCarList); 
    }
  }
}