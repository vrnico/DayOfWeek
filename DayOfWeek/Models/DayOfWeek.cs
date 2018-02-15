using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DayOfWeek.Models
{
  public class DayOfWeekGenerator
  {
      private int _day;
      private int _month;
      private int _year;

      public DayOfWeekGenerator(int day, int month, int year)
      {
          _day = day;
          _month = month;
          _year = year;
      }

      public int GetYear()
      {
          return 5;
      }

      public int GetDay()
      {
          return 0;
      }

      public int GetMonth()
      {
          return 0;
      }

  }
}
