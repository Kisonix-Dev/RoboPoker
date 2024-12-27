using System;
namespace RoboPoker.database
{
  class DataBase()
  {
    private readonly Random random = new Random()!;
    private readonly Text text = new Text()!;
    public void Numbers()
    {
      string[] options = { "Рейз 3.000", "Рейз 4.000", "Рейз 5.000", "Рейз 6.000", "Рейз 8.000", "Рейз 10.000", "Рейз 15.000",
                                "Рейз 25.000", "Рейз 30.000", "Рейз 35.000", "Рейз 40.000", "Рейз 45.000", "Рейз 50.000",
                                "Рейз 55.000", "Рейз 60.000", "Рейз 65.000", "Рейз 70.000", "Рейз 75.000", "Рейз 80.000",
                                "Рейз 95.000", "Рейз 100.000" };
      ShowRandomOption(options, text.Enter);
    }
    public void Two()
    {
      string[] options = { "Рейз", "Колл", "Пас" };
      ShowRandomOption(options, text.Enter);
    }
    public void Three()
    {
      string[] options = { "Рейз", "Чек", "Бет", "Пас" };
      ShowRandomOption(options, text.Enter);
    }
    public void Four()
    {
      string[] options = { "Рейз", "Чек", "Бет" };
      ShowRandomOption(options, text.Enter);
    }
    public void Five()
    {
      string[] options = { "Колл", "Пас" };
      ShowRandomOption(options, text.Enter);
    }
    public void Six()
    {
      string[] options = { "Бет", "Чек", "Пас" };
      ShowRandomOption(options, text.Enter);
    }
    private void ShowRandomOption(string[] options, Action nextAction)
    {
      int index = random.Next(options.Length);
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"Ваш оппонент сделал: {options[index]}");
      Console.ResetColor();
      nextAction();
      Console.ReadLine();
    }
  }
}