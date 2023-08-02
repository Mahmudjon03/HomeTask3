namespace FFF;
public  class Animal{
    int _legs;
    string _name;
    public Animal(string name,int legs)
    {
        _legs = legs;
        _name=name;
    }
      public string GetName(){
        return _name;
      }   
      public  void SetName(string name){
       _name=name;
}
public int GetLegs(){
    return _legs;
}
public  void SetLegs(int a){
       a=_legs;
}

  public virtual string Walk(){
  return $"Animal walk";
     }
     public virtual string Eat(){
        return $"Animel eat";
    }
    }
    

