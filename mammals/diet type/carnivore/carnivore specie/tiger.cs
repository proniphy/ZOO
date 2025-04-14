class Tiger : Carnivore
{
    public Tiger(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string origin,
        double averageBodyTemperature, string furType, string earType, string tailType, 
        double meatConsumptionPerDayKg, string favouritePrey)
        : base(name, birthDate, weightInKg, habitat, origin, averageBodyTemperature, furType, earType, tailType, 
               meatConsumptionPerDayKg, favouritePrey)
    { }
    public override void Vocalize()
    {
        Console.WriteLine($"{Name} roars loudly, a thunderous and fierce sound.");
    }
}
