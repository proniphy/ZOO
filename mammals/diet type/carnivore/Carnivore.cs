abstract class Carnivore : Mammal
{
    public double MeatConsumptionPerDayKg { get; set; }
    
    public string FavouritePrey { get; set; }

    public Carnivore() : base()
    {
        MeatConsumptionPerDayKg = 1.0;
        FavouritePrey = "Deer";
    }

    public Carnivore(string name, DateTime birthDate, double weightInKg, HabitatTypes habitat, string origin,
        double averageBodyTemperature, string furType, string earType, string tailType,
        double meatConsumptionPerDayKg, string favouritePrey)
        : base(name, birthDate, weightInKg, habitat, origin, averageBodyTemperature, furType, earType, tailType)
    {
        MeatConsumptionPerDayKg = meatConsumptionPerDayKg;
        FavouritePrey = favouritePrey;
    }

    public override string GetAnimalClass()
    {
        return "Carnivore mammal";
    }

    public override string GetAnimalClassInfo()
    {
        return "Carnivores are mammals that primarily feed on meat. They possess sharp teeth, strong jaws, and enhanced senses to effectively hunt their prey.";
    }

    public override string GetAnimalInformation()
    {
        string baseInfo = base.GetAnimalInformation();
        baseInfo += $"\nThis carnivore prefers {FavouritePrey.ToLower()} as prey,";
        baseInfo += $" and typically eats about {MeatConsumptionPerDayKg} kg of meat daily.";
        return baseInfo;
    }
}
