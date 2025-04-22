
namespace Zoo.Mammals
{
    abstract class Mammal : Animal, IVocalize
    {
        //All animals are warm blooded
        public bool IsWarmBlooded {get;set;} = true;
        private double averageBodyTemperature;

        //Fur type e.g. none for dolphins, long for alpaca/sheep, etc...
        public string? FurType {get; set;}
        //Ear type e.g. big for elephant, pointy for lynx, etc..
        public string? EarType {get; set;}
        //Tail type e.g. no tail for baboons, short/bushy for some type of cats
        public string? TailType{get; set;}

        public double AverageBodyTemperature
        {
            get => averageBodyTemperature;
            set
            {
                if(value<30||value>45)
                    throw new ArgumentOutOfRangeException("Temperature out of expected mammalian range.");
                else
                    averageBodyTemperature=value;
            }
        }
        //mammal without any arguments.
        public Mammal() : base()
        {
            AverageBodyTemperature = 37.0;
            FurType="Unspecified.";
            EarType="Unspecified.";
            TailType="Unspecified";
        }
        //actual mammal constructor that could be pointed to later on.
        public Mammal(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string origin
        , double averageBodyTemperature, string furType, string earType, string tailType)
        : base(name, birthDate, weightInKg, habitat, origin)
        {
            AverageBodyTemperature=averageBodyTemperature;
            FurType=furType;
            EarType=earType;
            TailType=tailType;
        }

    public abstract void Vocalize();

        public override string GetAnimalClass()
        {
            return "Mammal";
        }

        public static new string GetSpeciesInfo() //Basic mammal info
        {
            return "Most mammals are distinct by these characteristics:\n" +
                "  1. They're warm-blooded animals and typically have hair or fur.\n" +
                "  2. Most of them are born alive, and are fed with milk by the mother.\n" +
                "  3. Many mammals (e.g. elephants, wolves ...) live in groups.\n" +
                "  4. They generally have more complex brain than the rest of the animal kingdom.\n" +
                "  5. We can categorize mammals based on their diet in three groups:\n" +
                "    5.1. Carnivores.\n" +
                "    5.2. Herbivores.\n" +
                "    5.3. Omnivores.";
        }

        public override string GetDerivedSpeciesInfo() => GetSpeciesInfo();

        public override string GetAnimalInformation() //points to GetAnimalInformation in Animal.cs and adds on the extra info.
        {
            string info=base.GetAnimalInformation();

            info+=  $"\nJust like every mammal it is warm blooded," +
                    $"it has average body temperature: {AverageBodyTemperature}°C,\n " +
                    $"it has {EarType} ears, " +
                    $"also has {FurType} fur, " +
                    $"and a {TailType} tail.";

            return info;
        }
    }
}
