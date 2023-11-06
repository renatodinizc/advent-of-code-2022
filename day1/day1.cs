using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Day1
{
  static void Main(string[] args)
  {
    string[] entries = File.ReadAllLines("day1.txt");
    List<int> elves = new List<int>();
    int elf_total = 0;

    for(int i = 0; i < entries.Length; i++)
    {
      if (entries[i] == "")
      {
        elves.Add(elf_total);
        elf_total = 0;
        continue;
      }

      elf_total += Convert.ToInt32(entries[i]);

      if (i == entries.Length - 1)
      {
        elves.Add(elf_total);
      }
    }
    elves = elves.OrderByDescending(i => i).ToList();
    elves.Take(3).ToList().ForEach(Console.WriteLine);
    Console.WriteLine($"The total they are carrying is {elves.Take(3).ToList().Aggregate((a, b) => a + b)}.");
  }
}