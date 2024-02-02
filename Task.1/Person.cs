using System.Diagnostics;
using System.Drawing;

namespace Task._1;

public class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    } 
    public Person(){}
    public virtual void ToString()
    {
        System.Console.WriteLine($"Person {Name}");
    }
}
