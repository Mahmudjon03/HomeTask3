using Animals;
namespace Acanis;public class Canis:Animal{
    string _species;
   
   public Canis()
   {
    
   }
       public Canis(string species)
    {
        _species = species;
    }
    public Canis(string name,int legs,string species):base(name,legs)
    {
_species=species;
    }
    public string getSpecies(){
        return _species;
    }
    public void SetSpecies(string species){
        _species=species;
    }
    public override string GEtSound()
    {
     return "aff aff aff";  
       }
    
    public override bool IsScary()
    {
    return false;
    }
    public override string ToString()
    {
        return $"Name {_species} IsScary {IsScary()}species Canis";
    }
}
