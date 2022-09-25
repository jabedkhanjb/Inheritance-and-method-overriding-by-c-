using System;
abstract class Vehicle{public abstract void vehiclevarrient();
public void Vehiclecolor(){Console.WriteLine("Color must be Grey");} 
}
class Car : Vehicle{public override void vehiclevarrient()
    {Console.WriteLine("Toyota Fortuna 2020 Edition");}
}
class Program
{static void Main()
    {
        Car info = new Car();
        info.vehiclevarrient();
        info.Vehiclecolor();
    }
}