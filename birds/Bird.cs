
namespace Zoo.Birds
{
    class Bird : Animal, IVocalize, ISpeciesInfo
    {
        public bool Flying { get; protected set; }


        public Bird(string name, DateTime birthDate, double weightInKg,
            HabitatTypes habitat, string? originRegion = null, bool flying = true)
            : base(name, birthDate, weightInKg, habitat, originRegion)
        {
            Flying = flying;
        }

        public override string GetAnimalInformation()
        {
            string canFly = Flying ? "Additionaly, it can fly" : "Sadly, it can't fly";
            return $"{base.GetAnimalInformation()}. {canFly}.";
        }

        public void ShowBirdInformation()
        {
            base.ShowAnimalInformation();
        }

        public virtual void Vocalize()
        {
            Console.WriteLine("Chirp, chirp!");
        }

        public static new string GetSpeciesInfo()
        {
            return "Birds are warm-blooded vertebrates generally defined by:\n" +
                " - Having bodies covered in feathers\n" +
                " - Having toothless beaked jaws\n" +
                " - Laying hard-shelled eggs\n" +
                " - A high metabolic rate\n" +
                " - Ranging in size from tiny hummingbirds to large ostriches.";
        }

        public override string GetDerivedSpeciesInfo() => GetSpeciesInfo();
    }
}
