class Mammal : Animal, ISpeciesInfo
{
    public bool IsWarmBlooded {get; set; } = true; //Mammals are warm blooded

    public Mammal(string name, DateTime birthDate, double weightInKg,
        HabitatTypes habitat, string? originRegion = null, bool warmBlooded = true)
        : base(name, birthDate, weightInKg, habitat, originRegion)
    {
        IsWarmBlooded = warmBlooded;
    }

    public static bool IsMammal(Animal animal) //returns true or false
    {
        return animal is Mammal; //depending on if animal is or isn't a mammal
    }

    public static string GetSpeciesInfo() //Basic mammal info
    {
        return "Most mammals are distinct by these characteristics:\n" +
            "  1. They're warm-blooded animals and typically have hair or fur.\n" +
            "  2. Most of them are born alive, and are fed with milk by the mother.\n" +
            "  3. Many mammals (e.g. elephants, wolves ...) live in groups.\n" +
            "  4. They generally have more complex brain than the rest of the animal kingdom.\n" +
            "  5. We can categorize mammals based on their diet in three groups:\n" +
            "    5.1. Carnivores.\n" +
            "    5.2. Herbivores.\n" +
            "    5.3. Omnivores.";
    }

    public void ShowMammalInformation()
    {
        base.ShowAnimalInformation();
    }

    public void ShowMammalInformation()
    {
        Console.WriteLine($"{base.ShowAnimalInformation()}. It's from the {Habitat} habitat.");
    }
}