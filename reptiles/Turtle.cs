using reptile;
class Turtle : Reptile, ISwimmer
{
    public bool CanSwimUnderwater { get; private set; }
    public bool HasShell { get; } = true;

    public Turtle(string name, DateTime birthDate, double weight, HabitatTypes habitat,
        string? origin, int numberOfLegs, bool canSwimUnderwater)
        : base(name, birthDate, weight, habitat, origin, numberOfLegs, true) // Turtles have 4 legs, lay eggs
    {
        CanSwimUnderwater = canSwimUnderwater;
    }

    public override void Vocalize()
    {
        Console.WriteLine($"{Name} makes a low grunting or hissing sound.");
    }

    public override string GetAnimalInformation()
    {
        string info = $"    This animal is named: {Name}, it is {AgeInYears} years old, " +
            $"it weighs {Weight} kg and is native to the {NativeHabitat.FriendlyName()} habitat. \n" + 
            $"  1. It's a turtle with a shell and {(CanSwimUnderwater ? "can swim underwater" : "prefers land")}. \n" +
            "   2. Some species, like the Galápagos tortoise, can live over 100 years. Turtles have slow metabolisms, which contributes to their long lifespans. \n" +
            "   3. While they have lungs, some turtles can absorb oxygen through their skin or cloaca (rear end)—a handy trick for underwater survival, especially during hibernation. \n" +
            "   4. A turtle’s shell isn’t just armor—it's actually fused with their spine and ribs, making it a permanent, living part of their body. \n" +
            "They cannot crawl out of it like in cartoons. \n";
        if (!string.IsNullOrEmpty(RegionOfOrigin))
        {
            info += $" It was captured from the region {RegionOfOrigin}. ";
        }
        return info;
    }

    public void Swim()
    {
        if (CanSwimUnderwater)
        {
            Console.WriteLine($"{Name} dives underwater and swims gracefully.");
        }
        else
        {
            Console.WriteLine($"{Name} paddles near the surface.");
        }
    }
}