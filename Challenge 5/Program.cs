using System;

public class Program
{
    public static void Main()
    {
        Car car = new Car();
        Motorbike bike = new Motorbike();
        car.speed = 80f;
        bike.speed = 60f;

        car.isNeutral = false;
        bike.isNeutral = false;

        if (car.isNeutral == false)
            car.Move();

        bike.Move();


    }
}




