
namespace Zoo.Reptiles
{
    internal abstract class Lizard : Reptile
    {
        public override int NumberOfLegs
        {
            get => base.NumberOfLegs;
            set
            {
                if (value < 0 || value > 4)
                {
                    Console.WriteLine("A lizard cannot have more than 4 or less than 0 legs. Assigning default number of legs: 4.");
                    base.NumberOfLegs=4;
                }
                else
                {
                    base.NumberOfLegs=value;
                }
            }
        }
        public override double PreferredTemperature { get; set; } = 29.0;
        protected Lizard(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string? origin, int numberOfLegs, bool laysEggs)
            : base(name, birthDate, weightInKg, habitat, origin, numberOfLegs, laysEggs)
        {
        }
        public override void Sunbathe()
        {
            Console.WriteLine("This lizard is now sunbathing. The purpose of this is to regulate his temperature.");
        }
        public virtual void HideInShade()
        {
            Console.WriteLine("The lizard is now hiding in the shade, because its temperature got too high.");
        }
        public abstract void MoveOnSurface();
    }
}
