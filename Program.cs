using System;
using System.Collections.Generic;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Fish : Animal
{
    public double Weight { get; set; }

    public Fish(string name, int age, double weight) : base(name, age)
    {
        Weight = weight;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Weight: {Weight} kg");
    }
}

class Goldfish : Fish
{
    public string Color { get; set; }

    public Goldfish(string name, int age, double weight, string color)
        : base(name, age, weight)
    {
        Color = color;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Color: {Color}");
    }

    public void Swim()
    {
        Console.WriteLine($"{Name} is swimming.");
    }
}

class Sepia : Fish
{
    public double InkAmount { get; set; }

    public Sepia(string name, int age, double weight, double inkAmount)
        : base(name, age, weight)
    {
        InkAmount = inkAmount;
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Ink Amount: {InkAmount} L");
    }

    public void SquirtInk()
    {
        if (InkAmount > 0)
        {
            Console.WriteLine($"{Name} squirts ink!");
            InkAmount -= 0.1;
        }
        else
        {
            Console.WriteLine($"{Name} has no ink left!");
        }
    }
}

class Program
{
    static void Main()
    {
        List<Fish> fishList = new List<Fish>();

        Goldfish goldie = new Goldfish("Goldie", 2, 0.3, "Orange");
        Sepia inky = new Sepia("Inky", 4, 1.2, 0.7);

        fishList.Add(goldie);
        fishList.Add(inky);

        Console.WriteLine("Fish in the list:");
        foreach (Fish fish in fishList)
        {
            fish.PrintInfo();
            Console.WriteLine();
        }

        goldie.Swim();
        inky.SquirtInk();
    }
}

