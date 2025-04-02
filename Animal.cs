using System.Dynamic;

class Animal
{
    public string Name { get; init; }

    public DateTime BirthDate { get; init; }
    public double Weight { get; init; }    // In kilograms

    public int AgeInDays { get => (DateTime.Today - BirthDate).Days; }
    public int AgeInYears { get => AgeInDays / 365; }

    public Animal(string name, DateTime birthDate, double weightInKg)
    {
        if (DateTime.Today < birthDate)
        {
            throw new ArgumentOutOfRangeException("Animal cannot be born in the future");
        }
        if (weightInKg < 0)
        {
            throw new ArgumentOutOfRangeException("Weight cannot be negative");
        }
        if (weightInKg > 200_000)
        {
            // Based on largest living animal, the Blue whale, which can reach 190 tons
            throw new ArgumentOutOfRangeException("Weight cannot be larger than 200 tons");
        }

        Name = name;
        BirthDate = birthDate;
        Weight = weightInKg;
    }
<<<<<<< HEAD
    public Animal(string name, int age, int weight)
    {
        this.Name = name;
        this.Age = age;
        this.Weight= weight;
    }
    public Animal(int age, int weight)
    {
        this.Age = age;
        this.Weight= weight;
    }
    
=======

>>>>>>> 629e6a2d3efaa7e40f0034302bbe8fd93433d157
    public void ShowAnimalName()
    {
        Console.WriteLine($"The animal is named: {Name}");
    }

    public virtual string ShowAnimalInformation()
    {
        return $"This animal is named: {Name}, it is {AgeInYears} years old and it weighs {Weight} kg";
    }
}