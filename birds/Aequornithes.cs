abstract class Aequornithes : Neoaves
{
    public Aequornithes(string name, DateTime birthDate, double weightInKg,
        HabitatTypes habitat, string? originRegion = null, bool flying = true)
        : base(name, birthDate, weightInKg, habitat, originRegion, flying) { }

    public override string BirdType => "Aequornithes";

    public sealed override void DisplayFamily()
    {
        Console.WriteLine("Family: Aequornithes (can't be changed further)");
    }

    public override void UniqueFeature()
    {
        Console.WriteLine("Lives near water – aquatic bird!");
    }

    public override void Identify()
    {
        Console.WriteLine("I am an Aequornithes!");
    }
}