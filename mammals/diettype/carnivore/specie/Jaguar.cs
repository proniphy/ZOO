class Jaguar : Carnivore
{
    public Jaguar(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string origin,
        double averageBodyTemperature, string furType, string earType, string tailType, 
        double meatConsumptionPerDayKg, string favouritePrey)
        : base(name, birthDate, weightInKg, habitat, origin, averageBodyTemperature, furType, earType, tailType, 
               meatConsumptionPerDayKg, favouritePrey)
    { }
    public override void Vocalize()
    {
        Console.WriteLine($"{Name} roars deeply, a powerful and resonating sound.");
    }
    //
}