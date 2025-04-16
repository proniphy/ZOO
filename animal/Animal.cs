
abstract class Animal : INamed, IAdoptable, IHabitation
{
    /// <summary>
    /// The name of this animal.
    /// </summary>
    public string Name
    {
        get => name;
        set {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be null or empty");
            }
            name = value;
        }
    }
    private string name;

    /// <summary>
    /// The name of the person adopting this animal (if applicable).
    /// Can be changed by using the `Adopt` method
    /// </summary>
    public string? Adopter
    {
        get => adopter;
        set {
            if (value != null && value.Length == 0)
            {
                throw new ArgumentException("Adopter must be a non-empty name or null");
            }
            adopter = value;
        }
    }
    private string? adopter;

    /// <summary>
    /// The native habitat for this species of animal.
    /// </summary>
    public HabitatTypes NativeHabitat { get; set; }

    /// <summary>
    /// The date that this animal was born.
    /// </summary>
    public DateTime BirthDate
    {
        get => birthDate;
        set {
            if (value > DateTime.Today)
            {
                throw new ArgumentException("BirthDate cannot be in the future");
            }
            birthDate = value;
        }
    }
    private DateTime birthDate;

    /// <summary>
    /// Animal weight in kilograms.
    /// </summary>
    public double Weight
    {
        get => weight;
        set {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Weight cannot be negative");
            }
            if (value > 200_000)
            {
                // Based on largest living animal, the Blue whale, which can reach 190 tons
                throw new ArgumentOutOfRangeException("Weight cannot be larger than 200 tons");
            }
            weight = value;
        }
    }
    private double weight;

    /// <summary>
    /// Country/region this specific animal was captured from.
    /// </summary>
    public string? RegionOfOrigin
    {
        get => regionOfOrigin;
        set {
            if (value != null && value.Length == 0)
            {
                throw new ArgumentException("RegionOfOrigin must be non-empty or null");
            }
            adopter = value;
        }
    }
    private string? regionOfOrigin;

    public int AgeInDays { get => (DateTime.Today - BirthDate).Days; }
    public int AgeInYears { get => AgeInDays / 365; }

    public Animal()
    {
        name = "";
        adopter = null;
        NativeHabitat = 0;  // First value of the enum (since we don't have an "Invalid" option)
        birthDate = DateTime.Today;
        weight = 0;
        regionOfOrigin = null;
    }

    public Animal(string name, DateTime birthDate, double weightInKg,
        HabitatTypes habitat, string? origin)
        : this()
    {
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
    public virtual string GetAnimalClass() //helps so we can identify which class a animals belongs to
    {
        return "Unspecified animal class.";
    }

    public virtual string GetAnimalClassInfo() //prints basic class information
    {
        return "This is a basic animal.";
    }
}