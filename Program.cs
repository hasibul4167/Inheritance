﻿class Vahicle
{
    public string brand = "Ford";
    public void honk()
    {
    Console.WriteLine("Tuut,tuut!");
    }
}
class Car : Vahicle
{
    public string modelName = "Mustang";
}
class Program
{
    static void Main (string[]args)
    {
        Car myCar = new Car();
        myCar.honk();
        Console.WriteLine(myCar.brand+""+myCar.modelName);
    }   
}