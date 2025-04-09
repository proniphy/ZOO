
abstract class Reptile : Animal
{
    public int NumberOfLegs { get; protected set;}
    public bool IsColdBlooded { get; } = true;
    public bool LaysEggs { get; set; }
    
    public Reptile(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string? origin, int numberOfLegs, bool laysEggs) 
        : base(name, birthDate, weightInKg, habitat, origin)
    {
        if (numberOfLegs < 0)
        {
            throw new ArgumentOutOfRangeException("Reptile cannot have fewer than 0 legs.");
        }
        this.NumberOfLegs = numberOfLegs;
        this.LaysEggs = laysEggs;
    }

    public void Sunbathe()
    {
        Console.WriteLine("The Reptile is sunbathing currently...");
        Console.WriteLine("This is done so that the reptile regulates its internal temperature.");
    }

    public void ShowClassInformation()
    {
        Console.WriteLine("1. The reptiles are air-breathing vertebrates.");
        Console.WriteLine("2. The reptiles' skin is either made up of bony plates or scales. ");
        Console.WriteLine("3. There are many types of reptiles, such as lizards, tortoises, turtles, snakes and many more.");
        Console.WriteLine("4. Important dearure is that reptiles cannot regulate their body temperature internally.");
        Console.WriteLine("5. Most reptiles reproduce via laying eggs, however, some give birth to their offspring.");
    }

    public abstract void Vocalize();
}