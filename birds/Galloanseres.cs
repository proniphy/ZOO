namespace Zoo.Birds
{
    abstract class Galloansetes : Bird
    {
        public Galloansetes(string name, DateTime birthDate, double weightInKg,
            HabitatTypes habitat, string? originRegion = null, bool flying = true)
            : base(name, birthDate, weightInKg, habitat, originRegion, flying)
        {

        }

        public override string BirdType => "Galloanseres";
        public override void Identify()
        {
            Console.WriteLine("It is a Galloanseres bird!");
        }
    }
}