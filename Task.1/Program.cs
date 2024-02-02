




using Task._1;

var student1 = new Student("Ismoil","NUT");
var student2 = new Student("Isroil","NUT");
var teacher1 = new Teacher("Ghiyosov", "Algebra");
var teacher2 = new Teacher("Isroilova", "Languge");

student1.ToString();
student1.Study();
System.Console.WriteLine("--------------------------------------");
student2.ToString();
student2.Study();
System.Console.WriteLine("****************************************");
teacher1.ToString();
teacher1.Explain();
System.Console.WriteLine("--------------------------------------");
teacher2.ToString();
teacher2.Explain();
