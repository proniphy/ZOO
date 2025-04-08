using System;

namespace Zoo.Insects
{
    public class Mosquito : Insect
    {
        public bool IsMalariaCarrier { get; private set; }

        public Mosquito(string name, DateTime birthDate, double weightInKg,
                        HabitatTypes habitat, string? origin, bool canFly, bool isMalariaCarrier)
            : base(name, birthDate, weightInKg, habitat, origin, canFly)
        {
            IsMalariaCarrier = isMalariaCarrier;
            Status = new HealthStatus(false, "Monitor for disease");
        }

        public override void MakeSound()
        {
            Console.WriteLine("ZzzzzZZZzz...");
        }

        public override void ShowTypeFacts()
        {
            Console.WriteLine("Mosquitoes are known for transmitting malaria and other diseases.");
        }

        public override string GetAnimalInformation()
        {
            return base.GetAnimalInformation() + $" Is malaria carrier: {IsMalariaCarrier}.";
        }
    }
}
