namespace Task._3;

public class Dog : Animal
{
    public Dog(string name) : base(name){}
    public Dog(){}
    public override void SetName(string name)
    {
        Name = name;
    }
    public override string GetName()
    {
        return Name;
    }
    public override void Eat()
    {
        System.Console.WriteLine($"{Name} eating dog food");
    }
}
