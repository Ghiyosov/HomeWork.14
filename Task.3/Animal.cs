namespace Task._3;

public abstract class Animal
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public Animal(){}
    public abstract void SetName(string name);
    public abstract string GetName();
    public abstract void Eat();


}
