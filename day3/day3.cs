using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Day3
{
  static void Main(string[] args)
  {
    string[] entries = File.ReadAllLines("day3.txt");
    List<char> badges = new List<char>();

    for(int i = 0; i < entries.Length; i = i + 3)
    {
      foreach(char letter in entries[i])
      {
        if (entries[i].Contains(letter) &&
          entries[i + 1].Contains(letter) &&
          entries[i+2].Contains(letter))
        {
          badges.Add(letter);
          break;
        }
      }
    }

    // Create alphabet cipher
    Dictionary<char, int> cipher = new Dictionary<char,int>();
    int value = 0;
    for(char letter = 'a'; letter <= 'z'; letter++)
    {
      value += 1;
      cipher.Add(letter, value);
    }
    for(char letter = 'A'; letter <= 'Z'; letter++)
    {
      value += 1;
      cipher.Add(letter, value);
    }

    // Decipher
    List<int> badgePriorities = new List<int>();
    foreach(char item in badges)
    {
      badgePriorities.Add(cipher[item]);
    }

    // Sum items priorities
    int sum = badgePriorities.Aggregate((a,b) => a + b);
    Console.WriteLine($"The sum total of the priorities of the badges is {sum}.");
  }
}