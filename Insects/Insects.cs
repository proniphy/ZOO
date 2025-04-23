using System;
using Zoo;

namespace Zoo.Insects
{
    internal abstract class Insect : Animal, IVocalize, ISpeciesInfo
    {
        public bool CanFly { get; set; }

        public static int TotalInsects { get; private set; } = 0;

        public class HealthStatus
        {
            public bool IsVaccinated { get; set; }
            public string Notes { get; set; }

            public HealthStatus(bool isVaccinated, string notes)
            {
                IsVaccinated = isVaccinated;
                Notes = notes;
            }
        }

        public HealthStatus Status { get; set; }

        public Insect(string name, DateTime birthDate, double weightInKg,
                      HabitatTypes habitat, string? origin, bool canFly)
            : base(name, birthDate, weightInKg, habitat, origin)
        {
            CanFly = canFly;
            Status = new HealthStatus(false, "No info");
            TotalInsects++;
        }

        public static void PrintInsectCount()
        {
            Console.WriteLine($"Total insects: {TotalInsects}");
        }

        public override string GetAnimalInformation()
        {
            return base.GetAnimalInformation() + $" Can fly: {CanFly}.";
        }

        public abstract void ShowTypeFacts();
        public abstract void MakeSound(); // From Animal
        public void Vocalize() => MakeSound();

        public static new string GetSpeciesInfo()
        {
            return "Insects are invertebrates with exoskeletons, segmented bodies, and jointed appendages.";
        }

        public override string GetDerivedSpeciesInfo() => GetSpeciesInfo();
    }
}
