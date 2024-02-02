namespace Task._1;

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher(string name, string subject) : base(name)
    {
        Subject = subject;
    }
    public void Explain()
    {
        System.Console.WriteLine($"The teacher {Name} is explaining {Subject}");
    }
    public override void ToString()
    {
        System.Console.WriteLine($"Teacher {Name}");
    }
}
