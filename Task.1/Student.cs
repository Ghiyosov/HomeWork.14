using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace Task._1;

public class Student : Person
{
    public string Univers { get; set; }
    public Student(string name, string univers) : base(name)
    {
        Univers = univers;
    }
    public Student(){} 


    public void Study()
    {        
        System.Console.WriteLine($"The student {Name} is studying {Univers}");
    }
    public override void ToString()
    {
        System.Console.WriteLine($"Student {Name}");
    }
}
