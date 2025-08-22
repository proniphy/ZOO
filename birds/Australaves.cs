namespace Zoo.Birds
{
    abstract class Australaves : Bird
    {
        public Australaves(string name, DateTime birthDate, double weightInKg,
            HabitatTypes habitat, string? originRegion = null, bool flying = true)
            : base(name, birthDate, weightInKg, habitat, originRegion, flying) { }

        public override string BirdType => "Australaves";

        public override void Identify()
        {
            Console.WriteLine("I am an Australaves!");
        }
    }
}