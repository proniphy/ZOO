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

        Name = name;
        BirthDate = birthDate;
        Weight = weightInKg;
    }

    public void ShowAnimalName()
    {
        Console.WriteLine($"The animal is named: {Name}");
    }

    public virtual string ShowAnimalInformation()
    {
        return $"This animal is named: {Name}, it is {AgeInYears} years old and it weighs {Weight} kg";
    }
}