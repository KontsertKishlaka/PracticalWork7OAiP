namespace PracticalWork7OAiP;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ЗАДАНИЕ 1");
        Smartphon smartphon = new("IPhone", 100.1f, 4400);

        smartphon.DisplayInfo();
        smartphon.TurnOn();
        smartphon.TurnOff();


        Console.WriteLine("\nЗАДАНИЕ 2\n");

        Student student = new("Иван", 18, "1ИСП-11-42");
        Teacher teacher = new("Вадим Алесеевич", 44, "Математика");

        Console.WriteLine("Студент");
        student.Introduce();

        Console.WriteLine("\nУчитель");
        teacher.Introduce();


        Console.WriteLine("\nЗАДАНИЕ 3\n");

        Bird bird = new("Голубь", 200, 5);
        Fish fish = new("Треска", 200, "Северное море");

        Console.WriteLine("Птица");
        bird.PrintInfo();

        Console.WriteLine("\nРыба");
        fish.PrintInfo();
    }
}

public class ElectronicDevice
{
    public string? Name { get; set; }
    public float Power { get; set; }

    public ElectronicDevice(string? name, float power)
    {
        Name = name;
        Power = power;
    }

    public void TurnOn() => Console.WriteLine($"Девайс \"{Name}\" включён.");

    public void TurnOff() => Console.WriteLine($"Девайс \"{Name}\" выключён.");

    public virtual void DisplayInfo() => Console.WriteLine($"Мощность девайса \"{Name}\" составляет: {Power}");
}

public class Smartphon : ElectronicDevice
{
    public float BatteryCapacity { get; set; }

    public Smartphon(string? name, float power, float batteryCapacity) : base(name, power) => BatteryCapacity = batteryCapacity;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Ёмкость батареи \"{Name}\" составляет: {BatteryCapacity}");
    }
}

public class Person
{
    public string? Name { get; set; }
    public ushort Age { get; set; }

    public Person(string? name, ushort age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Introduce() => Console.WriteLine($"Имя: {Name}\nВозраст: {Age}");
}

public class Student : Person
{
    public string? StudyGroup {  get; set; }

    public Student(string? name, ushort age, string? studyGroup) : base(name, age) => StudyGroup = studyGroup;

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"Учебная группа: {StudyGroup}");
    }
}

public class Teacher : Person
{
    public string? Subject { get; set; }

    public Teacher(string? name, ushort age, string? subject) : base(name, age) => Subject = subject;

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine($"Предмет: {Subject}");
    }
}

public class Animal
{
    public string? Species { get; set; } // Вид животного
    public float Weight { get; set; } // Вес животного

    public Animal(string? species, float weight)
    {
        Species = species;
        Weight = weight;
    }

    public virtual void PrintInfo() => Console.WriteLine($"Вид животного: {Species}\nВес животного: {Weight}");

}

public class Bird : Animal
{
    public float WingSpan { get; set; } // Размах крыльев птицы

    public Bird(string? species, float weight, float wingSpan) : base(species, weight) => WingSpan = wingSpan;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Размах крыльев птицы: {WingSpan}");
    }
}

public class Fish : Animal
{
    public string? Habitat { get; set; } // Среда обитания рыбы (водоём)

    public Fish(string? species, float weight, string? habitat) : base(species, weight) => Habitat = habitat;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Среда обитания рыбы (водоём): {Habitat}");
    }
}