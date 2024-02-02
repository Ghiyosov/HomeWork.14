namespace Task._3;

public class Cow : Animal
{
    public Cow(string name) : base(name){}
    public Cow(){}
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
        System.Console.WriteLine($"{Name} eating plant");
    }
}
