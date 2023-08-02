namespace SPet;
using  FFF;
public class Pet:Animal{
   
    
   public Pet(string name,int lags):base(name,lags)
   {
    
   }
   
   public  string GetNeme(){
       return GetName();
   }
   public  void SetNeme(string f){
   SetName(f);
   }
   public virtual string Play(){
    return "";
   }
}