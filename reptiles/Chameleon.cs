
namespace Zoo.Reptiles
{
    internal abstract class Chameleon : Lizard, ICamouflaging
    {
        protected Chameleon(string name, DateTime birthDate, double weight, HabitatTypes habitat,
            string? origin, int numberOfLegs)
            : base(name, birthDate, weight, habitat, origin, numberOfLegs, true)     // Chameleons can only have 4 legs and can lay eggs.
        {
        }
        public override void MoveOnSurface()
        {
            Console.WriteLine($"{Name} can slowly climb branches.");
        }
        public override void Vocalize()
        {
            Console.WriteLine($"{Name} makes soft clicking sounds and hisss.\n");
        }
        public override double PreferredTemperature { get; set; } = 32.0;

        public override string GetAnimalInformation()
        {
            string info = $"    This animal is named: {Name}, it is {AgeInYears} years old, " +
                $"it weighs {Weight} kg and is native to the {NativeHabitat.FriendlyName()} habitat. \n" +
                $"  1. It's a color-shifting chameleon. While most people think chameleons change color only to blend into their environment, \n" +
                "they actually do it to communicate emotions like aggression, fear, or readiness to mate. Temperature and light also influence the change. \n" +
                "   2. A chameleon's tongue can be up to twice the length of its body and can launch out at lightning speed—up to 0.07 seconds—to snatch insects with sticky precision. \n" +
                "   3. Chameleons have independently rotating eyes—each eye can move in a different direction. This gives them a full 360° field of vision \n" +
                "and precise depth perception for spotting prey. \n";
            if (!string.IsNullOrEmpty(RegionOfOrigin))
            {
                info += $" It was captured from the region {RegionOfOrigin}. \n";
            }
            return info;
        }

        public void Camouflage()
        {
            Console.WriteLine($"{this.Name} blends into the surroundings.");
        }
        public override void DisplayDefenceMechanism()
        {
            Console.WriteLine($"{this.Name}, since he feels threatened, has changed its colors to blend with the background. Now it is very hard to spot him.");
            this.Camouflage();
        }
        public sealed override void Sunbathe()
        {
            base.Sunbathe();
            Console.WriteLine($"{this.Name}, the chameleon, prefers to stay in the sun until his temperature reaches {PreferredTemperature}");
        }
        public sealed override void HideInShade()
        {
            Console.WriteLine($"{this.Name} got too hot, and is now hiding in the shade.");
        }
    }
}
