using static System.Console;
using GameRPG_POO.src.Entities;

namespace GameRPG_POO
{
  class Program
  {
    static void Main(string[] args)
    {
      Knight knight = new Knight("Arus", 42, "Knight", 749, 72);
      Wizard whiteWizard = new Wizard("Jennica", 42, "White Wizard", 601, 482);
      Wizard blackWizard = new Wizard("Topapa", 42, "Black Wizard", 385, 641);

      WriteLine(knight.Attack());
      WriteLine(whiteWizard.Attack(5));
      WriteLine(blackWizard.Attack(8));
    }
  }
}