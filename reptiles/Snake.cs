class Snake : Reptile, IVenomous
{
    public bool IsVenomous { get; private set; }

    public Snake(string name, DateTime birthDate, double weight, HabitatTypes habitat,
        string? origin, bool isVenomous)
        : base(name, birthDate, weight, habitat, origin, 0, true) // Snakes have 0 legs, lay eggs
    {
        IsVenomous = isVenomous;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} hisses.");
    }

    public override void ShowAnimalInformation()
    {
        Console.WriteLine($"1. It is a snake with {(IsVenomous ? "venomous" : "non-venomous")} traits.");
        Console.WriteLine("2. Snakes flick their forked tongues to collect scent particles from the air and transfer them to a special organ called the Jacobson’s organ (or vomeronasal organ) on the roof of their mouth to 'smell' their environment.");
        Console.WriteLine("3. Snakes don’t truly dislocate their jaws, but they have very flexible ligaments that allow them to open their mouths up to 150°, letting them swallow prey much larger than their heads.");
        Console.WriteLine("4. Snakes don’t have eyelids. Instead, they have a transparent scale called a spectacle that covers and protects their eyes. It gives them that intense, unblinking stare.");
    }

    public void Bite()
    {
        Console.WriteLine(IsVenomous
            ? $"{Name} bites and injects venom!"
            : $"{Name} bites, but it's harmless.");
    }

    public override Vocalize()
    {
        Console.WriteLine($"{Name} can Hissss");
    }
}