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

      Console.WriteLine("Enter a NameSpace name");
      string nameSapce = Console.ReadLine();

      MakeFiles.Start(projName, nameSapce);
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