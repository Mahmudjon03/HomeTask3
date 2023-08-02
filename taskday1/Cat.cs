using SPet;
using FFF;
namespace Catt;



public class Cat :Pet{
    public Cat(string name,int legs):base(name,legs)
    {
    }
    public  string GetNameCat()
    {
    return GetNeme();
    }
    public void SetNameCat(string r){
           SetNeme(r);
    }
    public override string Play()
    {
        return $"Cat playing ";
    }
    public override string Eat()
    {
        return "Cat eat";
        }
    public override string Walk()
    {
        return $"cat walk";
    }
     
    }
