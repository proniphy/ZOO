abstract class Omnivore : Mammal
{
    public double FoodConsumptionPerDayKg { get; set; }
    public string FavouritePlantFood { get; set; }
    public string FavouriteAnimalFood { get; set; }

    public Omnivore() : base()
    {
        FoodConsumptionPerDayKg = 2.0;
        FavouritePlantFood = "Berries";
        FavouriteAnimalFood = "Insects";
    }

    public Omnivore(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string origin,
        double averageBodyTemperature, string furType, string earType, string tailType,
        double foodConsumptionPerDayKg, string favouritePlantFood, string favouriteAnimalFood)
        : base(name, birthDate, weightInKg, habitat, origin, averageBodyTemperature, furType, earType, tailType)
    {
        FoodConsumptionPerDayKg = foodConsumptionPerDayKg;
        FavouritePlantFood = favouritePlantFood;
        FavouriteAnimalFood = favouriteAnimalFood;
    }

    public override string GetAnimalClass()
    {
        return "Omnivore mammal";
    }

    public override string GetAnimalClassInfo()
    {
        return "Omnivores are mammals that eat both plant and animal-based food. Their teeth and digestive systems are adapted for a versatile diet.";
    }

    public override string GetAnimalInformation()
    {
        string baseInfo = base.GetAnimalInformation();
        baseInfo += $"\nThis omnivore enjoys both {FavouritePlantFood.ToLower()} and {FavouriteAnimalFood.ToLower()},";
        baseInfo += $" and eats about {FoodConsumptionPerDayKg} kg of food daily.";
        return baseInfo;
    }
}
