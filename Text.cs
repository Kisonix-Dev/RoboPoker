using System;
namespace RoboPoker
{
  class Text
  {
    public void Welcome()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"Добро пожаловать в RoboPoker!");
      Console.ResetColor();
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"♦️  ♣️  ♥️  ♠️");
      Console.WriteLine();
      Console.WriteLine($"1 - Начать");
      Console.WriteLine($"2 - Документация");
      Console.WriteLine($"3 - Выход из программы");
      Console.ResetColor();
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write($"Выберите опцию > ");
      Console.ResetColor();
    }
    public void Select()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"RoboPoker");
      Console.ResetColor();
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"1 - Рейз");
      Console.WriteLine($"2 - Рейз, колл, пас");
      Console.WriteLine($"3 - Рейз, чек, бет, пас (Префлоп)");
      Console.WriteLine($"4 - Рейз, чек, бет (Флоп)");
      Console.WriteLine($"5 - Колл, пас (Ва-банк)");
      Console.WriteLine($"6 - Бет, чек, пас");
      Console.WriteLine();
      Console.WriteLine($"♦️  ♣️  ♥️  ♠️");
      Console.WriteLine();
      Console.WriteLine($"end - Выход из программы");
      Console.ResetColor();
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.Write($"Выберите опцию > ");
      Console.ResetColor();
    }
    public void Enter()
    {
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write($"Нажмите на 'ENTER' что-бы продолжить!");
      Console.ResetColor();
    }
    public void Error()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"Ошибка!");
      Console.ResetColor();
    }
    public void Documentation()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"♦️  ♣️  ♥️  ♠️    Документация RoboPoker   ♦️  ♣️  ♥️  ♠️");
      Console.ResetColor();
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine($"1. Запустите программу (RoboPoker).");
      Console.WriteLine($"2. Приготовьте стек фишек для себя и своего оппонента.");
      Console.WriteLine($"3. Начните раздачу. Раздайте по две карты себе и своему оппоненту.");
      Console.WriteLine($"4. Сделайте SB, BB ставки.");
      Console.WriteLine($"5. Сделайте первый ход, в зависимости от позиции.");
      Console.WriteLine($"6. К примеру, вы выбрали опцию: Рейз 4.000.");
      Console.WriteLine($"7. Обратитесь к RoboPoker и к примеру вы выбрали опцию: Рейз-колл-пас.");
      Console.WriteLine($"- RoboPoker случайным образом выбирает опцию: Рейз.");
      Console.WriteLine($"8. Снова обратитесь к RoboPoker и выберите опцию: Рейз.");
      Console.WriteLine($"- RoboPoker так-же случайным образом выбирает значение: 50.000.");
      Console.WriteLine($"9. Далее слова за вами. К примеру вы выбрали опцию: Колл.");
      Console.WriteLine($"10. Играйте в обычном порядке как играли бы с реальным игроком либо за компьютером в покер (Техасский холдем).");
      Console.WriteLine($"- Опция бет делается не выше и не ниже ставки BB. (Большого блайнда).");
      Console.WriteLine($"- Если Рейз вашего оппонента ниже вашего рейза, то просто прибавьте +100% к ставке.");
      Console.WriteLine($"- На данный момент, опция ALL-IN для оппонента не реализована.");
      Console.ResetColor();
    }
    public void DocExit()
    {
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine($"Нажмите на 'ENTER' что-бы выйти из документации!");
      Console.ResetColor();
    }
  }
}