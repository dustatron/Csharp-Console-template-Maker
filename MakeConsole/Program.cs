using System;
using File.Models;

namespace File
{
  public class Program
  {
    public static void Main()
    {
      System.Console.WriteLine(@"
      _____    _  _    ______             _              _    ___  ___        _               
     /  __ \ _| || |_  | ___ \           (_)            | |   |  \/  |       | |              
     | /  \/|_  __  _| | |_/ /_ __  ___   _   ___   ___ | |_  | .  . |  __ _ | | __ ___  _ __ 
     | |     _| || |_  |  __/| '__|/ _ \ | | / _ \ / __|| __| | |\/| | / _` || |/ // _ \| '__|
     | \__/\|_  __  _| | |   | |  | (_) || ||  __/| (__ | |_  | |  | || (_| ||   <|  __/| |   
      \____/  |_||_|   \_|   |_|   \___/ | | \___| \___| \__| \_|  |_/ \__,_||_|\_\\___||_|   
                                        _/ |                                                  
                                       |__/                                                   
      ");
      Console.WriteLine("Enter path to Desktop");
      Console.Write("Path : ");
      string path = Console.ReadLine();

      Console.WriteLine("Enter Project name");
      Console.Write("Name : ");
      string projName = Console.ReadLine();

      Console.WriteLine("Enter a NameSpace name");
      Console.Write("NameSpace : ");
      string nameSapce = Console.ReadLine();

      MakeFiles.Start(path, projName, nameSapce);
      Console.WriteLine(@"
               _____  _____ ______  _____  _   _  _____   _____  _____ ___  ___ _____ 
              /  __ \|  _  ||  _  \|_   _|| \ | ||  __ \ |_   _||_   _||  \/  ||  ___|
              | /  \/| | | || | | |  | |  |  \| || |  \/   | |    | |  | .  . || |__  
              | |    | | | || | | |  | |  | . ` || | __    | |    | |  | |\/| ||  __| 
              | \__/\\ \_/ /| |/ /  _| |_ | |\  || |_\ \   | |   _| |_ | |  | || |___ 
               \____/ \___/ |___/   \___/ \_| \_/ \____/   \_/   \___/ \_|  |_/\____/ 
      ");
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
      System.Console.WriteLine("--------------------------  Remember to fill out your README!  --------------------");
      System.Console.WriteLine("-----------------------------    Make cool stuff, NOW!!!   ------------------------");
    }
  }

}

