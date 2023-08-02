using Animals;
public class Snake:Animal{
    string _color;
    string _species;
    public Snake(){}
    public Snake(string color)
    {
        _color = color;
    }public Snake(string name,string color,string species,int legs):base(name,legs)
    {   
        _color = color;
        _species=species;
    }
    public override string GEtSound()
    {
        return "sssssssssss";
    }
    public override bool IsScary()
    {
        return true;
    }
    public override string ToString()
    {
        return$"name {GetName()} color {_color} is scary {IsScary()}";
    }
    
}
