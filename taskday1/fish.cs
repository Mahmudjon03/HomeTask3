using SPet;
namespace Fishh;
public class Fish:Pet{
    public Fish(string name,int legs ):base(name,legs)
    {
        }
        public string GEtNameFish(){
            return GetNeme();
        }
        public void SetNameFish(string t){
            SetNeme(t);
            }
    public override string Eat()
    {
        return $"{GetNeme()} Eat ";
    }
    public override string Play()
    {
        return $"{GetNeme()} playing";
    }
    public override string Walk()
    {
        return $"{GetNeme()} walk";
    }
   }