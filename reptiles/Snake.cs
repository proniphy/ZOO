
namespace Zoo.Reptiles
{
    class Snake : Reptile, IVenomous
    {
        public bool IsVenomous { get; private set; }

        public Snake(string name, DateTime birthDate, double weight, HabitatTypes habitat,
            string? origin, int numberOfLegs, bool isVenomous)
            : base(name, birthDate, weight, habitat, origin, numberOfLegs, true) // Snakes have 0 legs, lay eggs
        {
            IsVenomous = isVenomous;
        }

        public override void Vocalize()
        {
            Console.WriteLine($"{Name} hisses.");
        }

        public override string GetAnimalInformation()
        {
            string info = $"    This animal is named: {Name}, it is {AgeInYears} years old, " +
                $"it weighs {Weight} kg and is native to the {NativeHabitat.FriendlyName()} habitat. \n" +
                $"  1. It is a snake with {(IsVenomous ? "venomous" : "non-venomous")} traits \n" +
                "   2. Snakes flick their forked tongues to collect scent particles from the air and transfer them to a special organ, \n" +
                "which is called the Jacobson’s organ (or vomeronasal organ) on the roof of their mouth to 'smell' their environment. \n" +
                "   3. Snakes don’t truly dislocate their jaws, but they have very flexible ligaments that allow them to open \n" +
                "their mouths up to 150°, letting them swallow prey much larger than their heads. \n" +
                "   4. Snakes don’t have eyelids. Instead, they have a transparent scale called a spectacle that covers and protects their eyes. \n"+
                "It gives them that intense, unblinking stare. \n";
            if (!string.IsNullOrEmpty(RegionOfOrigin))
            {
                info += $" It was captured from the region {RegionOfOrigin}. ";
            }
            return info;
        }

        public void Bite()
        {
            Console.WriteLine(IsVenomous
                ? $"{Name} bites and injects venom!"
                : $"{Name} bites, but it's harmless.");
        }
    }
}
