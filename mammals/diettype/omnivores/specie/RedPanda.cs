namespace Zoo.Mammals
{
    class RedPanda : Omnivore
    {
        public RedPanda(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string origin,
            double averageBodyTemperature, string furType, string earType, string tailType,
            double foodConsumptionPerDayKg, string favouritePlantFood, string favouriteAnimalFood)
            : base(name, birthDate, weightInKg, habitat, origin, averageBodyTemperature, furType, earType, tailType,
                  foodConsumptionPerDayKg, favouritePlantFood, favouriteAnimalFood)
        { }

        public override void Vocalize()
        {
            Console.WriteLine("The red panda makes a chattering sound.");
        }
    }
}