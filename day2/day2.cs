using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Day2
{
  static void Main(string[] args)
  {
    string[] entries = File.ReadAllLines("day2.txt");
    int total_score = 0;

    // Rock: A -- 1 point
    // Paper: B -- 2 points
    // Scissors: C -- 3 points
    // X means to loose
    // Y means to draw
    // Z means to win
    // Rounds: Win 6 points, draw 3 points, lost 0 points
    foreach(string entry in entries)
    {
      if (entry.First() == 'A' && entry.Last() == 'X')
      {
        total_score += (3 + 0);
      }
      else if (entry.First() == 'A' && entry.Last() == 'Y')
      {
        total_score += (1 + 3);
      }
      else if (entry.First() == 'A' && entry.Last() == 'Z')
      {
        total_score += (2 + 6);
      }
      else if (entry.First() == 'B' && entry.Last() == 'X')
      {
        total_score += (1 + 0);
      }
      else if (entry.First() == 'B' && entry.Last() == 'Y')
      {
        total_score += (2 + 3);
      }
      else if (entry.First() == 'B' && entry.Last() == 'Z')
      {
        total_score += (3 + 6);
      }
      else if (entry.First() == 'C' && entry.Last() == 'X')
      {
        total_score += (2 + 0);
      }
      else if (entry.First() == 'C' && entry.Last() == 'Y')
      {
        total_score += (3 + 3);
      }
      else if (entry.First() == 'C' && entry.Last() == 'Z')
      {
        total_score += (1 + 6);
      }
    }
    Console.WriteLine($"Your total score would be: {total_score}.");
  }
}