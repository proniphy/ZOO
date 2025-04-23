
namespace Zoo.Reptiles
{
    internal class PantherChameleon : Chameleon
    {
        public PantherChameleon(string name, DateTime birthDate, double weight, HabitatTypes habitat, string? origin, int numberOfLegs)
            : base(name, birthDate, weight, habitat, origin, numberOfLegs)
        {
        }
        public override void Vocalize()
        {
            base.Vocalize();
            Console.WriteLine($"When threatened, {Name} hisses or sometinmes makes a noise like meow-ing, accompanied with open mouthed behavior.");
        }
        public override string GetAnimalInformation()
        {
            string info = base.GetAnimalInformation();
            info += $"{Name} is a Panther Chameleon. The Panther is one of the most colorful of all chameleons, particularly the male chameleon.\n";
            info += "They sport an array of colors that rival a rainbow. Males have a broken white stripe that goes down the length of the body.\n";
            info += "The less flamboyant females are usually tan, gray or pale green. \n";
            return info;
        }
        public override void DisplayDefenceMechanism()
        {
            base.DisplayDefenceMechanism();
            Console.WriteLine($"Alongside changing its color, {Name} also puffs up its body to look more intimidating and threatening.");
        }
    }
}
