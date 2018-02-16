using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DayOfWeek.Models
{
  public class DayOfWeekGenerator
  {
      private int _year;
      private int _month;
      private int _day;

      public DayOfWeekGenerator(int year, int month, int day)
      {
          _year = year;
          _month = month;
          _day = day;
      }

      public int GetYear()
      {
          return _year;
      }

      public int GetDay()
      {
          return _day;
      }

      public int GetMonth()
      {
          return _month;
      }
      public string ReturnDayOfWeek()
      {
          DateTime dt = new DateTime(_year, _month, _day);
          return dt.DayOfWeek.ToString();
      }

  }
}
