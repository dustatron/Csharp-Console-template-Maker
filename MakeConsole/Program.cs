using System;
using File.Models;

namespace File
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Project name");
      string projName = Console.ReadLine();
      MakeFiles.Start(projName, "namespace");
      Console.WriteLine(@"
            __         __
           /.-'       `-.\
          //             \\
         /j_______________j\
        /o.-==-. .-. .-==-.o\
        ||      )) ((      ||
         \\____//   \\____//   
          `-==-'     `-==-'
      
      ");
      System.Console.WriteLine("Make cool stuff, NOW!!!");
    }

  }

}