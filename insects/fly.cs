using System;

namespace Zoo.Insects
{
    public class Fly : Insect
    {
        public int BuzzFrequency { get; set; }

        public Fly(string name, DateTime birthDate, double weightInKg,
                   HabitatTypes habitat, string? origin, bool canFly, int buzzFrequency)
            : base(name, birthDate, weightInKg, habitat, origin, canFly)
        {
            BuzzFrequency = buzzFrequency;
            Status = new HealthStatus(true, "Vaccinated");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Buzzing at {BuzzFrequency}Hz...");
        }

        public override void ShowTypeFacts()
        {
            Console.WriteLine("Flies can carry bacteria and reproduce quickly.");
        }

        public override string GetAnimalInformation()
        {
            return base.GetAnimalInformation() + $" Buzz frequency: {BuzzFrequency}Hz.";
        }
    }
}
