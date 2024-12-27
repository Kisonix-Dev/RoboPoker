using System;
using RoboPoker.database;
namespace RoboPoker
{
  class MainMenu
  {
    static void Main()
    {
      Text print = new Text()!;
      DataBase db = new DataBase()!;
      bool Menu = true;
      while (Menu)
      {
        try
        {
          print.Welcome();
          string option = Console.ReadLine()!;
          bool Select = true;
          bool Select2 = true;
          switch (option)
          {
            case "1":
              Menu = false;
              print.Welcome();
              while (Select)
              {
                print.Select();
                string select = Console.ReadLine()!;
                switch (select)
                {
                  case "1":
                    db.Numbers();
                    break;
                  case "2":
                    db.Two();
                    break;
                  case "3":
                    db.Three();
                    break;
                  case "4":
                    db.Four();
                    break;
                  case "5":
                    db.Five();
                    break;
                  case "6":
                    db.Six();
                    break;
                  case "end":
                    Console.Clear();
                    Select = false;
                    continue;
                  default:
                    Console.Clear();
                    break;
                }
              }
              continue;
            case "2":
              while (Select2)
              {
                print.Documentation();
                print.DocExit();
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input))
                {
                  Select2 = false;
                }
              }
              continue;
            case "3":
              Menu = false;
              continue;
            default:
              Console.Clear();
              break;
          }
        }
        catch (OverflowException)
        {
          print.Error();
        }
      }
    }
  }
}