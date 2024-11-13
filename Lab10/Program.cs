using System;

// Абстрактний клас
abstract class Transport
{
    public string Brand { get; set; }
    public string Model { get; set; }
    
    // Абстрактний метод
    public abstract void Start();
    
    // Звичайний метод
    public void DisplayInformation()
    {
        Console.WriteLine($"Бренд: {Brand}, Модель: {Model}");
    }
}

// Інтерфейс для транспортних засобів
interface IDriveable
{
    void Drive();
}

// Клас автомобіля
class Car : Transport, IDriveable
{
    public override void Start()
    {
        Console.WriteLine("Двигун автомобіля запущено.");
    }
    
    public void Drive()
    {
        Console.WriteLine("Автомобіль у русі.");
    }
}

// Клас велосипеда
class Bicycle : Transport, IDriveable
{
    public override void Start()
    {
        Console.WriteLine("Крутить педалі велосипеда.");
    }
    
    public void Drive()
    {
        Console.WriteLine("Велосипед у русі.");
    }
}

class Program
{
    static void Main()
    {
        // Створення екземплярів транспортних засобів
        Car myCar = new Car { Brand = "Toyota", Model = "Camry" };
        Bicycle myBicycle = new Bicycle { Brand = "Giant", Model = "Defy" };

        // Виведення інформації та виклик методів
        Console.WriteLine("Інформація про автомобіль:");
        myCar.DisplayInformation();
        myCar.Start();
        myCar.Drive();
        Console.WriteLine();

        Console.WriteLine("Інформація про велосипед:");
        myBicycle.DisplayInformation();
        myBicycle.Start();
        myBicycle.Drive();
    }
}