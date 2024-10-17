using System;

//MULTILEVEL INHERITANCE //others are same except multiple
class Animal
{
    public string walk()
    {
        return ("I can walk");
    }
    public string run()
    {
        return ("I can run");
    }
}
class Carnivo : Animal
{
    public string qualities()
    {
        return "Sharp";
    }
    public string food()
    {
        return "OTHER ANIMALS";
    }

}
class Tiger : Carnivo
{   
    public string family()
    {
        return "cat family";
    }
}

//multiple inheritance using interfaces
interface Car
{
    public string model_car();
}
interface Bike
{
    public string model_bike();
}

class cd : Car,Bike
{
public string model_car()
{
    return "bmw";
}
public string model_bike()
{
    return "harley";
}
}



class Inheritance
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Hello");
        System.Console.WriteLine("Nishint");

        Carnivo c=new Carnivo();
        Tiger t=new Tiger();

        System.Console.WriteLine(t.walk()+"......"+t.family());

        cd obj=new cd();
        System.Console.WriteLine(obj.model_bike()+"...."+obj.model_car()+"");

        /*
Hello
Nishint
I can walk......cat family
harley....bmw
*/
    

    }
}