using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Day4
{
  static void Main(string[] args)
  {
    string[] entries = File.ReadAllLines("day4.txt");
    int counter = 0;

    foreach (string entry in entries)
    {
      string range1 = entry.Split(",").First(), range2 = entry.Split(",").Last();

      int range1Start = Convert.ToInt32(range1.Split("-").First());
      int range1Count = Convert.ToInt32(range1.Split("-").Last()) - Convert.ToInt32(range1.Split("-").First()) + 1;
      int[] lot1 = Enumerable.Range(range1Start, range1Count).ToArray();

      int range2Start = Convert.ToInt32(range2.Split("-").First());
      int range2Count = Convert.ToInt32(range2.Split("-").Last()) - Convert.ToInt32(range2.Split("-").First()) + 1;
      int[] lot2 = Enumerable.Range(range2Start, range2Count).ToArray();

      if (lot1.Intersect(lot2).Any())
      {
        counter += 1;
      }
    }

    Console.WriteLine($"There is {counter} assignment pairs with intersections.");
  }
}