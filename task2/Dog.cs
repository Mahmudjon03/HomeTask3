using  Acanis;
public class Dog:Canis{
  public Dog ()
  {}
     public Dog(string name,string species):base(name)
     {
        
     }
    public override string GEtSound()
    {
        return base.GEtSound();
    }
    public override bool IsScary()
    {
        return base.IsScary();
    }
    public override string ToString()
    {
        return base.ToString();
    }
 }