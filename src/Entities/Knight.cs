namespace GameRPG_POO.src.Entities
{
  public class Knight : Heroes
  {
    public Knight(string Name, int Level, string HeroType, int HP, int MP)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.HP = HP;
      this.MP = MP;
    }
  }
}