using System;

class Hello
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
                       //NUMBERS 
               int rollno = 23;
               Console.WriteLine(rollno);//23

               long mobile = 8393964151L;
               long max = long.MaxValue;
               Console.WriteLine(mobile);//8393964151
               Console.WriteLine(max);

               float maxf = float.MaxValue;
               Console.WriteLine(maxf);


               //STRINGS
               string name = "Nishint Goyal";
               Console.WriteLine("YOUR NAME IS  "+name);

               char ch='a';
               Console.WriteLine(ch);

               //CONVERT STRINGS TO INTEGER
               string numb = "-21";
               int age = Convert.ToInt32(numb);
               Console.WriteLine(age);

               //STRING TO FLOAT
               string float_conv = "123.2";
               float conv=Convert.ToSingle(float_conv);
               Console.WriteLine(conv);

               //boolean data type
               bool vote = true;
               Console.WriteLine(vote);

               
               String temp = "Nishint ";
               temp += "Goyal";
               Console.WriteLine(temp);

               //var keyword

               var age2 = 21;
               Console.WriteLine(age2);

               var bigNumber = 90000L;
               Console.WriteLine(bigNumber);

               //const keyword

               const  int vat = 20;
               Console.WriteLine(vat);

               int balance = 1000;
               Console.WriteLine(balance * (vat/100D));


               //Odd even checker
               int num1 = 11;
               int num2 = 2;
               Console.WriteLine(num1%num2);//output=1 means odd 11%2=1 remd


          

               Console.WriteLine("ENTER YOUR First NAME BRO:");
               string nameinput = Console.ReadLine();
               Console.WriteLine(nameinput);

               Console.Write("Enter your last name");
               string sameLine=Console.ReadLine();
               Console.WriteLine(sameLine);

               Console.WriteLine(nameinput+sameLine);

               Console.WriteLine("Bro Enter your age please");
               int age21 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine(age21);

               if(age21>21)
                   Console.WriteLine("You can dance");
               else
                   Console.WriteLine("You can sing");

               

        int value = 10;

        Console.WriteLine(string.Format("{0} \n {1}",value,10000));

        double money = -1000 / 3D;
        Console.WriteLine(money);

        Console.WriteLine(string.Format("{0:0.00}",money));

        //ToStringFUnct tpo convet number to String
        int abc = 21;
        Console.WriteLine(abc.ToString());

       

        Console.WriteLine("Enter number ");
        string num = Console.ReadLine();
        int neg = -1;

        bool success=int.TryParse(num, out neg);

        if (success)
        {
           Console.WriteLine("successful");
        }
        else
        {
           Console.WriteLine("not successful");
        }


        Console.WriteLine(neg);

        //string lit

        string speech="He said \"nishint\" ";
        Console.WriteLine(speech);


        //Arrays

        Console.WriteLine("ENTER SIZE PLEASE");
        int SIZE = Convert.ToInt32(Console.ReadLine());


        int[] numw = new int[SIZE];

        for (int i = 0; i < numw.Length; i++)
        {
           Console.WriteLine("Enter elem :"+(i+1));
           numw[i]=Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numw);

        Console.WriteLine("YOUR SORTED ARRAY");
        foreach(int elem in numw)
        {

           Console.WriteLine(elem);
        }

        Console.WriteLine("YOUR REVERSE ARRAY");

        Array.Reverse(numw);

        foreach (int elem in numw)
        {
           Console.WriteLine(elem);
        }


        //Clear Array stored values to default


        Array.Clear(numw,2,1);

        Console.WriteLine("YOUR ARRAY AFTER CLEARING....");

        foreach (int elem in numw)
        {
           Console.WriteLine(elem+" ");
        }

        int pos=Array.IndexOf(numw,5);
        Console.WriteLine(pos);


         //LIST IN C#
         List<int> al=new List<int>();
          al.Add(0);
          al.Add(1);

          //list has count like in java list has .size()  here it is al.Count     for array it is arr.Length

          foreach(int elem in al)
          {
              Console.WriteLine(elem);
          }

          //DICTIONARY


          Dictionary<int,string> names= new Dictionary<int,string>();

          for(int i=0;i<5;i++)
          {

          }

          foreach(int key in names.Keys)
        { 
              Console.WriteLine(key + " "+ names[key]);
        }


        List<int> al = new List<int>();
        al.Add(1);
        al.Add(2);
        al.Add(-10);

        al.Sort();

        foreach(int elem in al)
           Console.WriteLine(elem);

        //FIRST 20 FIBONACCI SERIES USING LIST IN C#
        List<int> fibo = new List<int>();

        int first = 0;
        int second = 1;
        fibo.Add(first);
        fibo.Add(second);

        for (int i = 0; i < 19; i++)
        {
           fibo.Add(first + second);
           first = second;
           second = fibo[fibo.Count - 1];
        }
        int oo = 0;
        foreach (int elem in fibo)
        {
           Console.WriteLine("ELEMENT "+ oo++ + " is "+elem);
        }

    
           public class Solution
        {
           public string ReverseWords(string s)
           {
               s = s.Trim();
               string[] arr = s.Split(' ');

               string str = "";

               for (int i = arr.Length - 1; i >= 0; i--)
               {
                   if (arr[i] == "")
                       continue;

                   if (i != 0)
                       str += arr[i] + " ";
                   else
                       str += arr[i];
               }

               return str;
           }
        }
    public class Solution
    {
       public bool IsPalindrome(int x)
       {
           string str = x + "";


           char[] arr = str.ToCharArray();
           int last = arr.Length - 1;

           for (int i = 0; i < arr.Length / 2; i++)
           {
               if (arr[i] != arr[last--])
                   return false;
           }
           return true;

       }
    }
    public class Solution
    {
       public string MergeAlternately(string word1, string word2)
       {
           char[] arr1 = word1.ToCharArray();
           char[] arr2 = word2.ToCharArray();
           string ret = "";

           int i = 0;
           int j = 0;

           while (i < arr1.Length && j < arr2.Length)
           {
               ret += arr1[i];
               ret += arr2[j];
               i++;
               j++;
           }
           while (i < arr1.Length)
           {
               ret += arr1[i];
               i++;
           }
           while (j < arr2.Length)
           {
               ret += arr2[j];
               j++;
           }
           return ret;
       }
    }


    }


}















  