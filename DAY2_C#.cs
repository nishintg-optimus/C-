using System;

// public class Student
// {
//     public string StudentName
//     {get;set;}
// }

// public class Empty
// {

// }

// class DAY2
// {
//     static void ChangeReferenceType(Student std2)
// {
//     std2.StudentName="Nishint";
// }
//     static void Main()
//     {
//         System.Console.WriteLine("..................................................................");
//         DateTime now = DateTime.Now;
//         Console.WriteLine("Current Time: " + now.ToString("HH:mm:ss"));

//         Student obj1=new Student();
//         obj1.StudentName="Harry";
//         ChangeReferenceType(obj1);
//         System.Console.WriteLine(obj1.StudentName);

//         Empty emp=new Empty();
//        System.Console.WriteLine(emp.GetHashCode());
//        System.Console.WriteLine(emp.GetType());
//        System.Console.WriteLine(emp.ToString());
//         System.Console.WriteLine("..................................................................");

//     }
// }

namespace DESTRUCTORS
{
class person
{
    public string Name;
    public int age;
    public person(string Name,int age)
    {
        this.Name=Name;
        this.age=age;
    }
    public string getName()
    {
        
        return this.Name;
    }

    ~person()
    {
        System.Console.WriteLine("Destructor invoked here!!!!!!!!");
    }
}
class CALL
{
    static void Main(string[] args)
    {
        person obj=new person("Nishint",21);
        System.Console.WriteLine( obj.getName());
       
    }
}


}