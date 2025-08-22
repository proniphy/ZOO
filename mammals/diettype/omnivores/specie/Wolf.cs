namespace Zoo.Mammals
{
    class Wolf : Omnivore
    {
        public Wolf(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string origin,
            double averageBodyTemperature, string furType, string earType, string tailType,
            double foodConsumptionPerDayKg, string favouritePlantFood, string favouriteAnimalFood)
            : base(name, birthDate, weightInKg, habitat, origin, averageBodyTemperature, furType, earType, tailType,
                  foodConsumptionPerDayKg, favouritePlantFood, favouriteAnimalFood)
        { }
        public override void Vocalize()
        {
            Console.WriteLine("The wolf howls in the forest.");
        }
    }
}