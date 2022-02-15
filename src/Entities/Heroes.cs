namespace GameRPG_POO.src.Entities
{
  public abstract class Heroes
  {
    public Heroes(string Name, int Level, string HeroType, int HP, int MP)
    {
      this.Name = Name;
      this.Level = Level;
      this.HeroType = HeroType;
      this.HP = HP;
      this.MP = MP;
    }

    public Heroes()
    {

    }

    public string Name;
    public int Level;
    public string HeroType;
    public int HP;
    public int MP;

    public override string ToString()
    {
      return 
      $@"{this.Name} 
      Lv. {this.Level}  {this.HeroType}
      HP  {this.HP}
      MP  {this.MP}
      ";
    }

    public virtual string Attack()
    {
      return this.Name + " Attacked with his sword";
    }
  }
}