namespace GameRPG_POO.src.Entities
{
  public class Wizard : Heroes
  {
    public Wizard(string Name, int Level, string HeroType, int HP, int MP)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.HP = HP;
      this.MP = MP;
    }
    public override string Attack()
    {
      return this.Name + " Cast magic spell";
    }

    public string Attack(int Bonus)
    {
      if (Bonus > 6)
      {
        return this.Name + " cast special magic with bonus of " + Bonus;
      }
      else
      {
        return this.Name + " cast magic with bonus of " + Bonus;
      }
    }
  }
}