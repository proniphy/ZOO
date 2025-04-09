class Turtle : Reptile, ISwimmer
{
    public bool CanSwimUnderwater { get; private set; }
    public bool HasShell { get; } = true;

    public Turtle(string name, DateTime birthDate, double weight, HabitatTypes habitat,
        string? origin, bool canSwimUnderwater)
        : base(name, birthDate, weight, habitat, origin, 4, true) // Turtles have 4 legs, lay eggs
    {
        CanSwimUnderwater = canSwimUnderwater;
    }

    public override void Vocalize()
    {
        Console.WriteLine($"{Name} makes a low grunting or hissing sound.");
    }

    public override void ShowAnimalInformation()
    {
        Console.WriteLine($"1. It's a turtle with a shell and {(CanSwimUnderwater ? "can swim underwater" : "prefers land")}. ");
        Console.WriteLine("2. Some species, like the Galápagos tortoise, can live over 100 years. Turtles have slow metabolisms, which contributes to their long lifespans.");
        Console.WriteLine("3. While they have lungs, some turtles can absorb oxygen through their skin or cloaca (rear end)—a handy trick for underwater survival, especially during hibernation.");
        Console.WriteLine("4. A turtle’s shell isn’t just armor—it's actually fused with their spine and ribs, making it a permanent, living part of their body. They cannot crawl out of it like in cartoons.");

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