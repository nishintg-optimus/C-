using System.Linq;
using System.Collections.Generic;
public class Student
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Marks { get; set; }
}
public class Student1
{
    public int StudentId { get; set; }
    public string Name { get; set; }
}

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int StudentId { get; set; } // Foreign key to Student
}
class Linq
{

    static void Main(string[] args)
    {
        string sentence="HELLO NISHINT";
        string[] name={"A","AB","C","DA","E","F",};
        int[] numbers={1,2,3,4,5};


        var getTheNumbers= from elem in numbers
                           where elem>2
                           select elem;

        var getTheNames=from elem in name
                        where elem.Contains("A")
                        orderby elem ascending
                        select elem;

    
        List<int> list=new List<int>();

        foreach(int number in getTheNumbers)
        {
            if(number>4)
            list.Add(number);
        }

       System.Console.WriteLine(string.Join(",",getTheNumbers));
       System.Console.WriteLine(string.Join(",",list));
       System.Console.WriteLine(string.Join(",",getTheNames));


      List<List<int>> al=new List<List<int>>
       {
        new List<int>(){1,2,3,4,5},
        new List<int>(){2,3,4},
        new List<int>(){3,4,5}
       };

       var allTheNumbers =from elem in al
                          let numb=elem
                          where numb.Count>3
                          from x in numb
                          select x;

foreach(var n in allTheNumbers)
{
System.Console.Write(n+" ");  
}    


        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Gender = "Female", Marks = 85 },
            new Student { Name = "Bob", Gender = "Male", Marks = 90 },
            new Student { Name = "Charlie", Gender = "Male", Marks = 78 },
            new Student { Name = "Diana", Gender = "Female", Marks = 92 },
            new Student { Name = "Eve", Gender = "Female", Marks = 88 },
            new Student { Name = "Frank", Gender = "Male", Marks = 75 },
            new Student { Name = "Grace", Gender = "Female", Marks = 95 },
            new Student { Name = "Hank", Gender = "Male", Marks = 80 },
            new Student { Name = "Ivy", Gender = "Female", Marks = 87 },
            new Student { Name = "Jack", Gender = "Male", Marks = 82 },
             new Student { Name = "Jack", Gender = "Male", Marks = 82 },
             new Student { Name = "Jack", Gender = "Male", Marks = 102 },
              new Student { Name = "c#", Gender = "Male", Marks = 82 },
               new Student { Name = "c#", Gender = "Male", Marks = 92 },
               new Student { Name = "c#", Gender = "FeMale", Marks = 92 }
        };

        var genderGroup =from s in students
                        group s by s.Gender;

        foreach(var elem in genderGroup)
        {
            System.Console.WriteLine(elem.Key);
           foreach(var p in elem)
           {
            System.Console.WriteLine("."+p.Name+"."+p.Marks);
           }
        }

        var groupWithAge=from s in students
                        where s.Marks>0
                        group s by s.Marks;

        foreach(var elem in groupWithAge)
        {
        System.Console.WriteLine(elem.Key);
          foreach(var item in elem)
          {
            System.Console.WriteLine("."+item.Name+"."+item.Marks);
          }
        }

        var multipleKeys=from s in students
                        group s by new {s.Name, s.Gender};


        foreach(var elem in multipleKeys)
        {
            System.Console.WriteLine(elem.Key);

            foreach(var item in elem)
            {
                System.Console.WriteLine(item.Marks);
            }
        }

        System.Console.WriteLine(new string('-', 80));

        var orderedKeys=from s in multipleKeys
                        orderby s.Count() descending
                        select s;

        foreach(var elem in orderedKeys)
        {
            System.Console.WriteLine(elem.Key);

            foreach(var item in elem)
            {
                System.Console.WriteLine(item.Marks);
            }
        
        }


        System.Console.WriteLine(new string('-',70));


        var studentbyAge=from s in students
                         group s by s.Marks into marksgroup
                         orderby marksgroup.Key
                         select marksgroup;

        foreach(var key in studentbyAge)
        {
            System.Console.WriteLine(key.Key);

            foreach(var item in key)
            {
                System.Console.WriteLine(item.Name);
            }
        }


         List<Student1> student1 = new List<Student1>
        {
            new Student1 { StudentId = 1, Name = "Alice" },
            new Student1 { StudentId = 2, Name = "Bob" },
            new Student1 { StudentId = 3, Name = "Charlie" }
        };

        List<Course> courses = new List<Course>
        {
            new Course { CourseId = 101, CourseName = "Math", StudentId = 1 },
            new Course { CourseId = 102, CourseName = "Science", StudentId = 2 },
            new Course { CourseId = 103, CourseName = "History", StudentId = 1 },
            new Course { CourseId = 104, CourseName = "Art", StudentId = 3 }
        };



         System.Console.WriteLine(new string('-',70));




        var innerjoin=from s in student1
                      join b in courses
                      on s.StudentId equals b.StudentId
                      select new
                      {
                        Student1=s.Name
                        //courses=b.Name,b.District
                      };

         foreach(var item in innerjoin)
         {
            System.Console.WriteLine(item);
         }    

          System.Console.WriteLine(new string('-',70));

        System.Console.WriteLine("LAMBDA EXPRESSIONS");

        //extension methods 


        List<int> ng=new List<int>(){1,2,3,4,5};
        var oddnumbers=ng.Where(n => (n%2==1));
                          

        System.Console.WriteLine(string.Join(",",oddnumbers));


        student1.ForEach(w => Console.Write(w.StudentId+" "));


         System.Console.WriteLine(new string('-',70));

         var simpleGrouping=students.GroupBy(x=>x.Gender);

         foreach(var item in simpleGrouping)
         {
            System.Console.WriteLine("----------"+item.Key+"--------------");

            foreach(var x in item)
            {
                System.Console.WriteLine(x.Name);

            }
         }


  var simpleGrouping2=students.OrderBy(x=>x.Gender)
                     .GroupBy(x=>x.Gender);

         foreach(var item in simpleGrouping2)
         {
            System.Console.WriteLine("----------"+item.Key+"--------------");

            foreach(var x in item)
            {
                System.Console.WriteLine(x.Name +"..."+x.Marks);

            }
         }

         int[] arr={1,2,3,4,5};



         System.Console.WriteLine("-------");



         var evenOrOdd=arr.OrderBy(x=>x)
                          .GroupBy(x=>(x%2==0)?"EVEN":"ODD")
                          .OrderBy(x=>x.Count());

         foreach(var item in evenOrOdd)
         {
            System.Console.WriteLine(item.Key);

            foreach(var x in item)
            System.Console.WriteLine(x);
         }

         var innerJoin=student1.Join(courses, s=>s.StudentId,c=>c.StudentId,(s,c)=>new
         {
            student1=s.Name,
            courses=c.CourseName
         }
         );

         foreach(var item in innerJoin)
         System.Console.WriteLine(item.courses,item.student1);













       

        





        










    }
}


