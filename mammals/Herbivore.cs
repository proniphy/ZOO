class Herbivore : Mammal
{
    public string? FavoritePlant {get; set; }
    public override string? Habitat {get; set; }
    public override bool IsWarmBlooded {get; } =true;
    
    public override void MammalInformation()
    {
        Console.WriteLine("Most mammals are distinct by this characteristics: ");
        Console.WriteLine("1. They're warm-blooded animals and typically have hair or fur.");
        Console.WriteLine("2. Most of them are born alive, and are fed with milk by the mother.");
        Console.WriteLine("3. Many mammals (e.g. elephants, wolves ...) live in groups.");
        Console.WriteLine("4. They generally have more complex brain than the rest of the animal kingdom.");
        Console.WriteLine("5. We can categorize mammals based on their diet in three groups: ");
        Console.WriteLine("\t5.1. Carnivores.\n\t5.2. Herbivores.\n\t5.3. Omnivores.");
    }
    public override void FeedWithBabyMilk()
    {
        Console.WriteLine($"{Name} is being fed with baby milk.");
    }
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating {FavoritePlant}");
    }

    public Herbivore(string name, DateTime birthDate, double weightInKg, string habitat, string favoritePlant)
    : base (name, birthDate, weightInKg) //final constructor,
    {
        FavoritePlant=favoritePlant;
        Habitat = habitat;
    }
}