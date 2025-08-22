namespace Zoo.Mammals
{
    class Leopard : Carnivore
    {
        public Leopard(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string origin,
            double averageBodyTemperature, string furType, string earType, string tailType,
            double meatConsumptionPerDayKg, string favouritePrey)
            : base(name, birthDate, weightInKg, habitat, origin, averageBodyTemperature, furType, earType, tailType,
                   meatConsumptionPerDayKg, favouritePrey)
        { }
        public override void Vocalize()
        {
            Console.WriteLine($"{Name} growls softly, a low and throaty sound.");
        }
        //
    }
}
