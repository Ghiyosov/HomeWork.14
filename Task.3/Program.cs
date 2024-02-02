



using Task._3;

var dog1 = new Dog("Rex");
var dog2 = new Dog();
dog2.SetName("Rembo");
var cow = new Cow("Coww");

System.Console.WriteLine(dog1.GetName());
dog1.Eat();

System.Console.WriteLine("----------------------------");

System.Console.WriteLine(dog2.GetName());
dog2.Eat();

System.Console.WriteLine("----------------------------");

System.Console.WriteLine(cow.GetName());
cow.Eat();

