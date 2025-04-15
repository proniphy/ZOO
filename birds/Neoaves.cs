abstract class Neoaves : Bird
{
    protected Neoaves(string name, DateTime birthDate, double weightInKg,
        HabitatTypes habitat, string? originRegion = null, bool flying = true)
        : base(name, birthDate, weightInKg, habitat, originRegion, flying) { }

    public override string BirdType => "Neoaves";

    public virtual void DisplayFamily()
    {
        Console.WriteLine("Family: Neoaves");
    }

    public abstract void UniqueFeature();
}