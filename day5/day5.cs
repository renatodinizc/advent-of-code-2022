using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Day5
{
  static void Main(string[] args)
  {
    // Prepare first stack:
    List<string> firstStack = new List<string>();
    firstStack.Add("H");
    firstStack.Add("B");
    firstStack.Add("V");
    firstStack.Add("W");
    firstStack.Add("N");
    firstStack.Add("M");
    firstStack.Add("L");
    firstStack.Add("P");

    // Prepare second stack: 
    List<string> secondStack = new List<string>();
    secondStack.Add("M");
    secondStack.Add("Q");
    secondStack.Add("H");

    // Prepare third stack:
    List<string> thirdStack = new List<string>();
    thirdStack.Add("N");
    thirdStack.Add("D");
    thirdStack.Add("B");
    thirdStack.Add("G");
    thirdStack.Add("F");
    thirdStack.Add("Q");
    thirdStack.Add("M");
    thirdStack.Add("L");

    // Prepare fourth stack:
    List<string> fourthStack = new List<string>();
    fourthStack.Add("Z");
    fourthStack.Add("T");
    fourthStack.Add("F");
    fourthStack.Add("Q");
    fourthStack.Add("M");
    fourthStack.Add("W");
    fourthStack.Add("G");

    // Prepare fifth stack:
    List<string> fifthStack = new List<string>();
    fifthStack.Add("M");
    fifthStack.Add("T");
    fifthStack.Add("H");
    fifthStack.Add("P");

    // Prepare sixth stack:
    List<string> sixthStack = new List<string>();
    sixthStack.Add("C");
    sixthStack.Add("B");
    sixthStack.Add("M");
    sixthStack.Add("J");
    sixthStack.Add("D");
    sixthStack.Add("H");
    sixthStack.Add("G");
    sixthStack.Add("T");

    // Prepare seventh stack:
    List<string> seventhStack = new List<string>();
    seventhStack.Add("M");
    seventhStack.Add("N");
    seventhStack.Add("B");
    seventhStack.Add("F");
    seventhStack.Add("V");
    seventhStack.Add("R");

    // Prepare eighth stack:
    List<string> eighthStack = new List<string>();
    eighthStack.Add("P");
    eighthStack.Add("L");
    eighthStack.Add("H");
    eighthStack.Add("M");
    eighthStack.Add("R");
    eighthStack.Add("G");
    eighthStack.Add("S");

    // Prepare ninth stack:
    List<string> ninthStack = new List<string>();
    ninthStack.Add("P");
    ninthStack.Add("D");
    ninthStack.Add("B");
    ninthStack.Add("C");
    ninthStack.Add("N");

    string[] entries = File.ReadAllLines("day5.txt");
    SortedList<string, List<string>> sortedList = new SortedList<string, List<string>>();
    sortedList["1"] = firstStack;
    sortedList["2"] = secondStack;
    sortedList["3"] = thirdStack;
    sortedList["4"] = fourthStack;
    sortedList["5"] = fifthStack;
    sortedList["6"] = sixthStack;
    sortedList["7"] = seventhStack;
    sortedList["8"] = eighthStack;
    sortedList["9"] = ninthStack;

    foreach (string entry in entries)
    {
      int numberOfItems = Convert.ToInt32(entry.Split(" ")[1]);
      List<string> fromStack = sortedList[entry.Split(" ")[3]];
      List<string> toStack = sortedList[entry.Split(" ").Last()];

      List<string> createsInMotion = fromStack.GetRange(fromStack.Count - 1 - (numberOfItems - 1), numberOfItems);
      fromStack.RemoveRange(fromStack.Count - 1 - (numberOfItems - 1), numberOfItems);

      createsInMotion.ForEach(crate => toStack.Add(crate));
    }

    string result = "";

    foreach(List<string> stack in sortedList.Values.ToArray())
    {
      if(stack.Any())
      {
        result += stack.Last();
      }
    }

    Console.WriteLine($"The list of creates on top in order are {result}.");
  }
}