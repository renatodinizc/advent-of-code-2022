using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Day6
{
  static void Main(string[] args)
  {
    string entry = File.ReadAllLines("day6.txt").First();

    for(int i = 0; i < entry.Length; i++)
    {
      bool result = false;
      Dictionary<char, bool> register = new Dictionary<char, bool>();
      register.Add(entry[i], true);

      InnerLoopForEntry(entry, register, i, ref result);

      if (result)
      {
        break;
      }
    }
  }

  static void InnerLoopForEntry(string entry,
                                Dictionary<char, bool> register,
                                int i,
                                ref bool result)
  {
    for(int j = 1; j < 14; j++)
    {
      if (register.ContainsKey(entry[i + j]))
      {
        break;
      }
      else if (j == 13)
      {
        Console.WriteLine($"The answer is {i+j + 1}.");
        result = true;
      }
      else
      {
        register.Add(entry[i + j], true);
      }
    }
  }
}