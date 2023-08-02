namespace Animals;

public abstract class Animal{
    string _name;
      int _legs;
      public Animal(){}
      
      public Animal(string name,int legs)
      {
        _name = name;
        _legs = legs;
    }
    public string GetName(){
        return _name;
    }
    public int GetLegs(){
        
        return _legs;
    }
    public void SetName(string name){
       _name=name;
    }
public void SetLegs(int legs){
    _legs=legs;
}
public abstract string GEtSound();
public abstract bool IsScary();
public abstract string ToString();
}

