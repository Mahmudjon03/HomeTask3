using Catt;
using Fishh;
using Spiderr;
var cat =new Cat("aaaa",12);
 System.Console.WriteLine(cat.GetName());  
   cat.SetNameCat("test");
    System.Console.WriteLine(cat.GetName());
System.Console.WriteLine(cat.Eat());
System.Console.WriteLine(cat.Play());
System.Console.WriteLine(cat.Walk());
System.Console.WriteLine("---------------------------------------------");

 
var sr =new Spider("tervreg",11);
System.Console.WriteLine(sr.Eat());
System.Console.WriteLine("--------------------------------------------------");
var fish= new Fish("mmm",14);
System.Console.WriteLine(fish.GEtNameFish());
fish.SetNameFish("testt");
System.Console.WriteLine(fish.GEtNameFish());


System.Console.WriteLine(fish.Eat());
System.Console.WriteLine(fish.Play());
System.Console.WriteLine(fish.Walk());


