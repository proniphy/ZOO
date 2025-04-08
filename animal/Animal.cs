
abstract class Animal : INamed, IAdoptable, IHabitation
{
    /// <summary>
    /// The name of this animal.
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// The name of the person adopting this animal (if applicable).
    /// </summary>
    public string? Adopter { get; protected set; } = null;

    /// <summary>
    /// The native habitat for this species of animal.
    /// </summary>
    public HabitatTypes NativeHabitat { get; protected set; }

    /// <summary>
    /// The date that this animal was born.
    /// </summary>
    public DateTime BirthDate { get; init; }

    /// <summary>
    /// Animal weight in kilograms.
    /// </summary>
    public double Weight { get; init; }

    /// <summary>
    /// Country/region this specific animal was captured from.
    /// </summary>
    public string? RegionOfOrigin { get; init; }

    public int AgeInDays { get => (DateTime.Today - BirthDate).Days; }
    public int AgeInYears { get => AgeInDays / 365; }

    public Animal(string name, DateTime birthDate, double weightInKg,
        HabitatTypes habitat, string? origin)
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
        NativeHabitat = habitat;
        RegionOfOrigin = origin;
    }

    public void Rename(string newName)
    {
        Name = newName;
    }

    public void Adopt(string? newAdopter)
    {
        Adopter = newAdopter;
    }

    public virtual string GetAnimalInformation()
    {
        string info = $"This animal is named: {Name}, it is {AgeInYears} years old, " +
            $"it weighs {Weight} kg and is native to the {NativeHabitat.FriendlyName()} habitat. ";
        if (!string.IsNullOrEmpty(RegionOfOrigin))
        {
            info += $" It was captured from the region {RegionOfOrigin}. ";
        }
        return info;
    }

    public void ShowAnimalInformation()
    {
        Console.WriteLine($"{GetAnimalInformation()}");
    }
}