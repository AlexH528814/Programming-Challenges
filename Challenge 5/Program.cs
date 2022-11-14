using System;

public class Program
{
    public static void Main()
    {
        Car car = new Car();
        Motorbike bike = new Motorbike();
        car.speed = 80f;
        bike.speed = 60f;

        bike.isNeutral = true;
        car.Move();
        bike.Move();


    }
}

public class Vehicle
{
    public float speed;

    public bool isNeutral;

    public void Move()
    {
        if (isNeutral)
            return;
        

        Console.WriteLine("Vehicle is moving");
    }
}

public class Car : Vehicle
{
    public int numberOfSeats;

    public void StoreItemsInBoot()
    {
        Console.WriteLine("items stored");
    }
}

public class Motorbike : Vehicle
{
    public bool hasSideCarridge;

    public void Wheely()
    {
        Console.WriteLine("this is not safe at all...");
    }
}