class Mammal : Animal
{
    public bool IsWarmBlooded {get; set; } = true; //Mammals are warm blooded
    public string? Habitat {get; set; } //living habitat of an animal

    public Mammal (string? name, int age, int weight, bool isWarmBlooded, string? habitat)
    : base(name, age, weight)
    {
        this.Habitat=habitat;
    }

    public static bool IsMammal(Animal animal) //returns true or false
    {
        return animal is Mammal; //depending on if animal is or isn't a mammal
    }
    public static void MammalInformation() //Basic mammal info
    {
        Console.WriteLine("Most mammals are distinct by this characteristics: ");
        Console.WriteLine("1. They're warm-blooded animals and typically have hair or fur.");
        Console.WriteLine("2. Most of them are born alive, and are fed with milk by the mother.");
        Console.WriteLine("3. Many mammals (e.g. elephants, wolves ...) live in groups.");
        Console.WriteLine("4. They generally have more complex brain than the rest of the animal kingdom.");
        Console.WriteLine("5. We can categorize mammals based on their diet in three groups: ");
        Console.WriteLine("\t5.1. Carnivores.\n\t5.2. Herbivores.\n\t5.3. Omnivores.");
    }
}