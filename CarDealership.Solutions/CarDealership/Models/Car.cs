using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private static List<Car> _instances = new List<Car> {};

    public string make { get; set; }
    public string model { get; set; }
    public string type { get; set; }
    public int price { get; set; }
    public string year { get; set; }
    public int mpg { get; set; }
    public string condition { get; set; }

    public Car()
    {
      _instances.Add(this);
    }


    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}

//Make
//Model
//Type
//Price
//Year
//MPG
//Condition













// Let user add new cars
// Constructor, getters, setters, properties